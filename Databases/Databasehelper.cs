using System;
using System.Data.SQLite;
using System.Windows.Forms;
namespace Hospital_Management.Databases
{
    public class DatabaseHelper
    {
        private static string dbPath = "HospitalDB.sqlite";
        private static string connectionString = $"Data Source={dbPath};Version=3;Journal Mode=WAL;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public static void InitializeDatabase()
        {
            using (var conn = GetConnection())
            {
                conn.Open();

                string createUsers = @"
                CREATE TABLE IF NOT EXISTS Users (
                    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Username TEXT NOT NULL UNIQUE,
                    Password TEXT NOT NULL,
                    Role TEXT NOT NULL
                        CHECK (Role IN ('Admin', 'Doctor', 'Patient'))
                );";

                string createWards = @"
                CREATE TABLE IF NOT EXISTS Wards (
                    WardID INTEGER PRIMARY KEY AUTOINCREMENT,
                    WardName TEXT NOT NULL UNIQUE
                );";

                string createDoctors = @"
                CREATE TABLE IF NOT EXISTS Doctors (
                    DoctorID INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserID INTEGER NOT NULL UNIQUE,
                    Specialization TEXT NOT NULL,
                    WardID INTEGER,
                    MonthlySalary REAL NOT NULL
                        CHECK (MonthlySalary >= 0),
                    FOREIGN KEY (UserID)
                        REFERENCES Users(UserID)
                        ON DELETE CASCADE,
                    FOREIGN KEY (WardID)
                        REFERENCES Wards(WardID)
                        ON DELETE SET NULL
                );";

                string createPatients = @"
                CREATE TABLE IF NOT EXISTS Patients (
                    PatientID INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserID INTEGER NOT NULL UNIQUE,
                    Age INTEGER
                        CHECK (Age >= 0),
                    Gender TEXT
                        CHECK (Gender IN ('Male', 'Female', 'Other')),
                    WardID INTEGER,
                    BedNumber INTEGER,
                    AdmitDate TEXT NOT NULL,
                    PerNightCharge REAL NOT NULL
                        CHECK (PerNightCharge >= 0),
                    FOREIGN KEY (UserID)
                        REFERENCES Users(UserID)
                        ON DELETE CASCADE,
                    FOREIGN KEY (WardID)
                        REFERENCES Wards(WardID)
                        ON DELETE SET NULL,
                    UNIQUE (WardID, BedNumber)
                );";

                string createAssignments = @"
                CREATE TABLE IF NOT EXISTS Assignments (
                    AssignmentID INTEGER PRIMARY KEY AUTOINCREMENT,
                    PatientID INTEGER NOT NULL,
                    DoctorID INTEGER NOT NULL,
                    MeetingTime TEXT NOT NULL,
                    FOREIGN KEY (PatientID)
                        REFERENCES Patients(PatientID)
                        ON DELETE CASCADE,
                    FOREIGN KEY (DoctorID)
                        REFERENCES Doctors(DoctorID)
                        ON DELETE CASCADE
                );";

                string createPrescriptions = @"
                CREATE TABLE IF NOT EXISTS Prescriptions (
                    PrescriptionID INTEGER PRIMARY KEY AUTOINCREMENT,
                    PatientID INTEGER NOT NULL,
                    DoctorID INTEGER NOT NULL,
                    MedicineName TEXT NOT NULL,
                    MedicinePrice REAL NOT NULL
                        CHECK (MedicinePrice >= 0),
                    PrescriptionDate TEXT NOT NULL
                        DEFAULT CURRENT_TIMESTAMP,
                    FOREIGN KEY (PatientID)
                        REFERENCES Patients(PatientID)
                        ON DELETE CASCADE,
                    FOREIGN KEY (DoctorID)
                        REFERENCES Doctors(DoctorID)
                        ON DELETE CASCADE
                );";

                string createBilling = @"
                CREATE TABLE IF NOT EXISTS Billing (
                    BillingID INTEGER PRIMARY KEY AUTOINCREMENT,
                    PatientID INTEGER NOT NULL UNIQUE,
                    TotalStayCharge REAL NOT NULL DEFAULT 0
                        CHECK (TotalStayCharge >= 0),
                    TotalMedicineCharge REAL NOT NULL DEFAULT 0
                        CHECK (TotalMedicineCharge >= 0),
                    GrandTotal REAL NOT NULL DEFAULT 0
                        CHECK (GrandTotal >= 0),
                    BillingDate TEXT NOT NULL
                        DEFAULT CURRENT_TIMESTAMP,
                    FOREIGN KEY (PatientID)
                        REFERENCES Patients(PatientID)
                        ON DELETE CASCADE
                );";

                foreach (string query in new[] { createUsers, createWards, createDoctors, createPatients, createAssignments, createPrescriptions, createBilling })
                {
                    new SQLiteCommand(query, conn).ExecuteNonQuery();
                }

                // Default admin
                string checkAdmin = "SELECT COUNT(*) FROM Users WHERE Role = 'Admin'";
                long adminCount = (long)new SQLiteCommand(checkAdmin, conn).ExecuteScalar();
                if (adminCount == 0)
                {
                    new SQLiteCommand("INSERT INTO Users (Name, Username, Password, Role) VALUES ('Administrator', 'admin', '1234', 'Admin')", conn).ExecuteNonQuery();
                }

                // Default wards
                string checkWards = "SELECT COUNT(*) FROM Wards";
                long wardCount = (long)new SQLiteCommand(checkWards, conn).ExecuteScalar();
                if (wardCount == 0)
                {
                    string[] wards = { "Emergency", "Surgery", "Cardiology", "Nephrology", "General", "ICU" };
                    foreach (string ward in wards)
                        new SQLiteCommand($"INSERT INTO Wards (WardName) VALUES ('{ward}')", conn).ExecuteNonQuery();
                }

                // Seed doctors, patients, billing
                SeedData(conn);
            }
        }

        private static void SeedData(SQLiteConnection conn)
        {
            if ((long)new SQLiteCommand("SELECT COUNT(*) FROM Doctors", conn).ExecuteScalar() > 0) return;
            // --- DOCTORS (30) ---
            string[,] doctors = {
        {"Dr. Ahmad Ali",        "ahmad.ali",        "Emergency Medicine", "1", "15000"},
        {"Dr. Sara Ali",         "sara.ali",         "General Surgery",    "2", "18000"},
        {"Dr. Usman Malik",      "usman.malik",      "Cardiology",         "3", "20000"},
        {"Dr. Ayesha Raza",      "ayesha.raza",      "Nephrology",         "4", "17500"},
        {"Dr. Bilal Hassan",     "bilal.hassan",     "General Medicine",   "5", "12000"},
        {"Dr. Zara Sheikh",      "zara.sheikh",      "ICU Specialist",     "6", "22000"},
        {"Dr. Omar Farooq",      "omar.farooq",      "Emergency Medicine", "1", "15500"},
        {"Dr. Hina Baig",        "hina.baig",        "Cardiology",         "3", "19500"},
        {"Dr. Kamran Iqbal",     "kamran.iqbal",     "Nephrology",         "4", "17000"},
        {"Dr. Nadia Hussain",    "nadia.hussain",    "General Surgery",    "2", "16000"},
        {"Dr. Farhan Ahmed",     "farhan.ahmed",     "Emergency Medicine", "1", "15800"},
        {"Dr. Sana Qureshi",     "sana.qureshi",     "General Surgery",    "2", "18200"},
        {"Dr. Imran Khan",       "imran.khan",       "Cardiology",         "3", "21000"},
        {"Dr. Rabia Noor",       "rabia.noor",       "Nephrology",         "4", "17800"},
        {"Dr. Danish Malik",     "danish.malik",     "General Medicine",   "5", "12500"},
        {"Dr. Mahnoor Aslam",    "mahnoor.aslam",    "ICU Specialist",     "6", "22500"},
        {"Dr. Yasir Shah",       "yasir.shah",       "Emergency Medicine", "1", "15200"},
        {"Dr. Kiran Akhtar",     "kiran.akhtar",     "Cardiology",         "3", "19800"},
        {"Dr. Salman Raza",      "salman.raza",      "Nephrology",         "4", "17200"},
        {"Dr. Areeba Khan",      "areeba.khan",      "General Surgery",    "2", "16500"},
        {"Dr. Hamza Tariq",      "hamza.tariq",      "General Medicine",   "5", "13000"},
        {"Dr. Mehwish Ali",      "mehwish.ali",      "ICU Specialist",     "6", "23000"},
        {"Dr. Sohail Anwar",     "sohail.anwar",     "Emergency Medicine", "1", "16000"},
        {"Dr. Mehwish Tariq",    "mehwish.tariq",    "Cardiology",         "3", "20500"},
        {"Dr. Faisal Iqbal",     "faisal.iqbal",     "Nephrology",         "4", "17600"},
        {"Dr. Nida Fatima",      "nida.fatima",      "General Surgery",    "2", "16800"},
        {"Dr. Adnan Rauf",       "adnan.rauf",       "General Medicine",   "5", "12800"},
        {"Dr. Bushra Ahmed",     "bushra.ahmed",     "ICU Specialist",     "6", "23500"},
        {"Dr. Waqar Hussain",    "waqar.hussain",    "Emergency Medicine", "1", "15700"},
        {"Dr. Marium Khalid",    "marium.khalid",    "Cardiology",         "3", "20200"}
    };

            for (int i = 0; i < 30; i++)
            {
                new SQLiteCommand($"INSERT INTO Users (Name, Username, Password, Role) VALUES ('{doctors[i, 0]}', '{doctors[i, 1]}', '1234', 'Doctor')", conn).ExecuteNonQuery();
                long uid = conn.LastInsertRowId;
                new SQLiteCommand($"INSERT INTO Doctors (UserID, Specialization, WardID, MonthlySalary) VALUES ({uid}, '{doctors[i, 2]}', {doctors[i, 3]}, {doctors[i, 4]})", conn).ExecuteNonQuery();
            }

            // --- PATIENTS (80 rows currently) ---
            string[,] patients = {
        {"Ali Raza",         "ali.raza",         "1", "1",  "34", "Male",   "2026-05-01", "450"},
        {"Fatima Noor",      "fatima.noor",      "1", "2",  "22", "Female", "2026-05-03", "520"},
        {"Hassan Tariq",     "hassan.tariq",     "1", "3",  "45", "Male",   "2026-05-05", "610"},
        {"Sana Malik",       "sana.malik",       "1", "4",  "31", "Female", "2026-05-07", "480"},
        {"Umar Shakeel",     "umar.shakeel",     "1", "5",  "60", "Male",   "2026-05-09", "750"},
        {"Zainab Iqbal",     "zainab.iqbal",     "1", "6",  "28", "Female", "2026-05-11", "390"},
        {"Bilal Chaudhry",   "bilal.chaudhry",   "1", "7",  "50", "Male",   "2026-05-13", "680"},
        {"Hira Baig",        "hira.baig",        "1", "8",  "37", "Female", "2026-05-15", "540"},
        {"Saad Farooq",      "saad.farooq",      "1", "9",  "42", "Male",   "2026-05-02", "470"},
        {"Amna Sheikh",      "amna.sheikh",      "1", "10", "25", "Female", "2026-05-04", "620"},
        {"Tariq Mehmood",    "tariq.mehmood",    "1", "11", "55", "Male",   "2026-05-06", "510"},
        {"Rukhsar Ahmed",    "rukhsar.ahmed",    "1", "12", "40", "Female", "2026-05-08", "430"},
        {"Fahad Hussain",    "fahad.hussain",    "1", "13", "33", "Male",   "2026-05-10", "590"},
        {"Maria Khan",       "maria.khan",       "1", "14", "48", "Female", "2026-05-12", "700"},
        {"Imran Ali",        "imran.ali",        "2", "1",  "29", "Male",   "2026-05-14", "460"},
        {"Nadia Jabbar",     "nadia.jabbar",     "2", "2",  "36", "Female", "2026-05-16", "530"},
        {"Asim Raza",        "asim.raza",        "2", "3",  "52", "Male",   "2026-05-01", "640"},
        {"Bushra Naz",       "bushra.naz",       "2", "4",  "44", "Female", "2026-05-03", "580"},
        {"Hamid Iqbal",      "hamid.iqbal",      "2", "5",  "27", "Male",   "2026-05-05", "410"},
        {"Sobia Arif",       "sobia.arif",       "2", "6",  "61", "Female", "2026-05-07", "720"},
        {"Kashif Anwar",     "kashif.anwar",     "2", "7",  "38", "Male",   "2026-05-09", "490"},
        {"Rabia Saleem",     "rabia.saleem",     "2", "8",  "23", "Female", "2026-05-11", "560"},
        {"Adnan Qureshi",    "adnan.qureshi",    "2", "9",  "47", "Male",   "2026-05-13", "670"},
        {"Sumera Dar",       "sumera.dar",       "2", "10", "35", "Female", "2026-05-15", "440"},
        {"Faisal Rehman",    "faisal.rehman",    "2", "11", "53", "Male",   "2026-05-02", "610"},
        {"Shehzad Mirza",    "shehzad.mirza",    "2", "12", "41", "Male",   "2026-05-04", "500"},
        {"Lubna Hassan",     "lubna.hassan",     "2", "13", "30", "Female", "2026-05-06", "390"},
        {"Waqar Ahmed",      "waqar.ahmed",      "2", "14", "58", "Male",   "2026-05-08", "850"},
        {"Nazish Bukhari",   "nazish.bukhari",   "3", "1",  "26", "Female", "2026-05-10", "470"},
        {"Junaid Nawaz",     "junaid.nawaz",     "3", "2",  "49", "Male",   "2026-05-12", "660"},
        {"Farah Ali",        "farah.ali",        "3", "3",  "32", "Female", "2026-05-14", "520"},
        {"Omer Khalid",      "omer.khalid",      "3", "4",  "43", "Male",   "2026-05-16", "610"},
        {"Ayesha Rauf",      "ayesha.rauf",      "3", "5",  "24", "Female", "2026-05-01", "430"},
        {"Salman Iqbal",     "salman.iqbal",     "3", "6",  "56", "Male",   "2026-05-03", "740"},
        {"Hina Tariq",       "hina.tariq",       "3", "7",  "39", "Female", "2026-05-05", "550"},
        {"Danish Akram",     "danish.akram",     "3", "8",  "28", "Male",   "2026-05-07", "480"},
        {"Mehwish Noor",     "mehwish.noor",     "3", "9",  "46", "Female", "2026-05-09", "690"},
        {"Usman Farooq",     "usman.farooq",     "3", "10", "51", "Male",   "2026-05-11", "620"},
        {"Kiran Malik",      "kiran.malik",      "3", "11", "27", "Female", "2026-05-13", "410"},
        {"Hamza Qureshi",    "hamza.qureshi",    "3", "12", "34", "Male",   "2026-05-15", "570"},
        {"Rabia Hussain",    "rabia.hussain",    "3", "13", "29", "Female", "2026-05-02", "460"},
        {"Taimoor Shah",     "taimoor.shah",     "3", "14", "63", "Male",   "2026-05-04", "880"},
        {"Hamza Aslam",      "hamza.aslam",      "4", "1",  "25", "Female", "2026-05-06", "530"},
        {"Kamran Ahmed",     "kamran.ahmed",     "4", "2",  "54", "Male",   "2026-05-08", "640"},
        {"Aliha Fatima",     "aliha.fatima",     "4", "3",  "31", "Female", "2026-05-10", "490"},
        {"Kamran Shah",      "kamran.shah",      "4", "4",  "44", "Male",   "2026-05-12", "720"},
        {"Huma Khan",        "huma.khan",        "4", "5",  "22", "Female", "2026-05-14", "450"},
        {"Ali Iqbal",        "ali.iqbal",        "4", "6",  "58", "Male",   "2026-05-16", "810"},
        {"Bushra Bibi",      "bushra.bibi",      "4", "7",  "36", "Female", "2026-05-01", "560"},
        {"Adan Rauf",        "adan.rauf",        "4", "8",  "48", "Male",   "2026-05-03", "630"},
        {"Mariam Khalid",    "mariam.khalid",    "4", "9",  "27", "Female", "2026-05-05", "420"},
        {"Waqas Hussain",    "waqas.hussain",    "4", "10", "61", "Male",   "2026-05-07", "900"},
        {"Sania Qureshi",    "sania.qureshi",    "4", "11", "33", "Female", "2026-05-09", "510"},
        {"Owais Tariq",      "owais.tariq",      "4", "12", "40", "Male",   "2026-05-11", "680"},
        {"Rabia Asghar",     "rabia.asghar",     "4", "13", "29", "Female", "2026-05-13", "470"},
        {"Faisal Akhtar",    "faisal.akhtar",    "4", "14", "57", "Male",   "2026-05-15", "760"},
        {"Huma Sheikh",      "huma.sheikh",      "5", "1",  "26", "Female", "2026-05-02", "390"},
        {"Bilal Raza",       "bilal.raza",       "5", "2",  "45", "Male",   "2026-05-04", "580"},
        {"Noreen Ali",       "noreen.ali",       "5", "3",  "34", "Female", "2026-05-06", "430"},
        {"Saif Ullah",       "saif.ullah",       "5", "4",  "52", "Male",   "2026-05-08", "690"},
        {"Zara Khan",        "zara.khan",        "5", "5",  "23", "Female", "2026-05-10", "500"},
        {"Danishh Malik",    "danishh.malik",    "5", "6",  "47", "Male",   "2026-05-12", "620"},
        {"Amina Rauf",       "amina.rauf",       "5", "7",  "30", "Female", "2026-05-14", "470"},
        {"Usama Farooq",     "usama.farooq",     "5", "8",  "55", "Male",   "2026-05-16", "840"},
        {"Kiran Ahmed",      "kiran.ahmed",      "5", "9",  "28", "Female", "2026-05-01", "410"},
        {"Salman Qureshi",   "salman.qureshi",   "5", "10", "43", "Male",   "2026-05-03", "650"},
        {"Mehwish Taariq",   "mehwish.taariq",   "5", "11", "37", "Female", "2026-05-05", "520"},
        {"Tahir Iqbal",      "tahir.iqbal",      "5", "12", "60", "Male",   "2026-05-07", "790"},
        {"Sadia Noor",       "sadia.noor",       "5", "13", "24", "Female", "2026-05-09", "440"},
        {"Hamza Ahmed",      "hamza.ahmed",      "5", "14", "39", "Male",   "2026-05-11", "610"},
        {"Laiba Hassan",     "laiba.hassan",     "6", "1",  "21", "Female", "2026-05-13", "530"},
        {"Omer Raza",        "omer.raza",        "6", "2",  "50", "Male",   "2026-05-15", "720"},
        {"Sana Iqbal",       "sana.iqbal",       "6", "3",  "29", "Female", "2026-05-02", "480"},
        {"Khurram Malik",    "khurram.malik",    "6", "4",  "62", "Male",   "2026-05-04", "950"},
        {"Ayesha Ahmed",     "ayesha.ahmed",     "6", "5",  "35", "Female", "2026-05-06", "560"},
        {"Junaid Farooq",    "junaid.farooq",    "6", "6",  "44", "Male",   "2026-05-08", "670"},
        {"Maham Khan",       "maham.khan",       "6", "7",  "27", "Female", "2026-05-10", "450"},
        {"Bilal Hussain",    "bilal.hussain",    "6", "8",  "53", "Male",   "2026-05-12", "780"},
        {"Rabia Akhtar",     "rabia.akhtar",     "6", "9",  "31", "Female", "2026-05-14", "510"},
        {"Fahad Ali",        "fahad.ali",        "6", "10", "46", "Male",   "2026-05-16", "640"}
    };

            int patientCount = patients.GetLength(0);  // Dynamically get the real count (80)

            // Doctor assignments for each patient (cycle through 30 doctors)
            int[] docIDs = new int[patientCount];
            for (int i = 0; i < patientCount; i++)
            {
                docIDs[i] = (i % 30) + 1;
            }

            // Medicine and pricing data (30 items)
            string[] medicines = {
        "Paracetamol","Amoxicillin","Omeprazole","Lisinopril","Amlodipine",
        "Ciprofloxacin","Pantoprazole","Clopidogrel","Insulin","Salbutamol",
        "Azithromycin","Digoxin","Losartan","Tramadol","Metronidazole",
        "Ceftriaxone","Morphine","Heparin","Dopamine","Hydrocortisone",
        "Phenytoin","Rifampicin","Fluconazole","Tacrolimus","Norepinephrine",
        "Midazolam","Atropine","Labetalol","Mannitol","Ibuprofen"
    };
            double[] medPrices = {
        150,300,180,400,280, 450,160,500,600,200,
        380,480,310,270,190, 700,800,550,900,420,
        340,460,520,1200,950, 1500,600,750,680,200
    };
            int[] nights = {
        24,22,20,18,16, 23,21,19,17,15,
        24,22,20,18,16, 23,21,19,17,15,
        24,22,20,18,16, 23,21,19,17,15
    };

            // Insert patients, assignments, prescriptions, billing
            for (int i = 0; i < patientCount; i++)
            {
                int idx = i % 30;

                new SQLiteCommand($"INSERT INTO Users (Name, Username, Password, Role) VALUES ('{patients[i, 0]}', '{patients[i, 1]}', '1234', 'Patient')", conn).ExecuteNonQuery();
                long uid = conn.LastInsertRowId;

                new SQLiteCommand($"INSERT INTO Patients (UserID, Age, Gender, WardID, BedNumber, AdmitDate, PerNightCharge) VALUES ({uid}, {patients[i, 4]}, '{patients[i, 5]}', {patients[i, 2]}, {patients[i, 3]}, '{patients[i, 6]}', {patients[i, 7]})", conn).ExecuteNonQuery();
                long pid = conn.LastInsertRowId;

                new SQLiteCommand($"INSERT INTO Assignments (PatientID, DoctorID, MeetingTime) VALUES ({pid}, {docIDs[i]}, '10:00 AM')", conn).ExecuteNonQuery();

                new SQLiteCommand($"INSERT INTO Prescriptions (PatientID, DoctorID, MedicineName, MedicinePrice, PrescriptionDate) VALUES ({pid}, {docIDs[i]}, '{medicines[idx]}', {medPrices[idx]}, '2025-04-15')", conn).ExecuteNonQuery();

                double stayCharge = nights[idx] * double.Parse(patients[i, 7]);
                double grandTotal = stayCharge + medPrices[idx];
                new SQLiteCommand($"INSERT INTO Billing (PatientID, TotalStayCharge, TotalMedicineCharge, GrandTotal, BillingDate) VALUES ({pid}, {stayCharge}, {medPrices[idx]}, {grandTotal}, '2025-05-01')", conn).ExecuteNonQuery();
            }
        }
    }
}