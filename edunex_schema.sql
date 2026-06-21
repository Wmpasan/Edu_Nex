-- ==========================================
-- Ready for import to XAMPP / phpMyAdmi
-- ==========================================

CREATE DATABASE IF NOT EXISTS `EduNex` CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci;
USE `EduNex`;

-- ==========================================
-- Teachers
-- ==========================================
DROP TABLE IF EXISTS `Teachers`;
CREATE TABLE `Teachers` (
  `TeacherID` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(100) NOT NULL,
  `Email` VARCHAR(100) NOT NULL,
  `Password` VARCHAR(255) NOT NULL,
  `PhoneNumber` VARCHAR(15) DEFAULT NULL,
  `Subject` VARCHAR(50) DEFAULT NULL,
  `Class` VARCHAR(20) DEFAULT NULL,
  `JoiningDate` DATETIME NOT NULL,
  `IsActive` TINYINT(1) NOT NULL DEFAULT 1,
  `CreatedDate` DATETIME DEFAULT CURRENT_TIMESTAMP,
  `UpdatedDate` DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`TeacherID`),
  UNIQUE KEY `UQ_Teachers_Email` (`Email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- sample teachers (includes admin with Class = 'All')
INSERT INTO `Teachers` (`TeacherID`,`Name`,`Email`,`Password`,`PhoneNumber`,`Subject`,`Class`,`JoiningDate`,`IsActive`) VALUES
(1,'Alice Smith','alice.smith@edunex.com','hash_pass_1','555-1001','Mathematics','10th','2020-01-15',1),
(2,'Bob Johnson','bob.johnson@edunex.com','hash_pass_2','555-1002','Science','9th','2019-08-20',1),
(3,'Carol Williams','carol.williams@edunex.com','hash_pass_3','555-1003','English','8th','2021-03-10',1),
(4,'David Brown','david.brown@edunex.com','hash_pass_4','555-1004','History','10th','2018-11-05',1),
(5,'Eva Davis','eva.davis@edunex.com','hash_pass_5','555-1005','Computer Science','11th','2022-07-22',1),
(6,'Admin Pasan','admin@edunex.com','admin123','0771234567','Class Management','All','2026-06-21',1);

ALTER TABLE `Teachers` AUTO_INCREMENT = 7;

-- ==========================================
-- Students
-- ==========================================
DROP TABLE IF EXISTS `Students`;
CREATE TABLE `Students` (
  `StudentID` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(100) NOT NULL,
  `RollNumber` VARCHAR(20) NOT NULL,
  `DateOfBirth` DATE NOT NULL,
  `Gender` VARCHAR(10) DEFAULT NULL,
  `Address` VARCHAR(255) DEFAULT NULL,
  `PhoneNumber` VARCHAR(15) DEFAULT NULL,
  `ParentName` VARCHAR(100) DEFAULT NULL,
  `ParentPhoneNumber` VARCHAR(15) DEFAULT NULL,
  `ParentEmail` VARCHAR(100) DEFAULT NULL,
  `EnrollmentDate` DATE NOT NULL,
  `Class` VARCHAR(20) DEFAULT NULL,
  `MonthlyFee` DECIMAL(10,2) DEFAULT 0.00,
  `IsActive` TINYINT(1) NOT NULL DEFAULT 1,
  `CreatedDate` DATETIME DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`StudentID`),
  UNIQUE KEY `UQ_Students_RollNumber` (`RollNumber`),
  KEY `idx_class` (`Class`),
  KEY `idx_status` (`IsActive`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- sample students
INSERT INTO `Students` (`StudentID`,`Name`,`RollNumber`,`DateOfBirth`,`Gender`,`Address`,`PhoneNumber`,`ParentName`,`ParentPhoneNumber`,`ParentEmail`,`EnrollmentDate`,`Class`,`MonthlyFee`,`IsActive`) VALUES
(1,'Rajesh Kumar','S001','2008-05-15','Male','123 Main Street, Colombo','0711111111','Lakshmi Kumar','0766666661','rajesh.p@example.com','2023-06-01','10-A',5000.00,1),
(2,'Priya Sharma','S002','2008-08-22','Female','456 Oak Avenue, Colombo','0712222222','Vijay Sharma','0767777762','priya.p@example.com','2023-06-01','10-A',5000.00,1),
(3,'Arjun Singh','S003','2008-03-18','Male','789 Pine Road, Colombo','0713333333','Harish Singh','0768888863','arjun.s@example.com','2023-06-01','10-B',5000.00,1),
(4,'Anaya Patel','S004','2009-01-10','Female','321 Elm Street, Colombo','0714444444','Rajesh Patel','0769999964','anaya.p@example.com','2023-06-01','9-A',5000.00,1),
(5,'Vikram Reddy','S005','2008-11-25','Male','654 Maple Lane, Colombo','0715555555','Suresh Reddy','0760000065','vikram.r@example.com','2023-06-01','9-B',5000.00,1),
(6,'Divya Nair','S006','2009-02-14','Female','987 Birch Street, Colombo','0716666666','Arun Nair','0761111166','divya.n@example.com','2023-06-01','10-A',5000.00,1),
(7,'Sanjay Verma','S007','2008-07-20','Male','135 Cedar Road, Colombo','0717777777','Ashok Verma','0762222267','sanjay.v@example.com','2023-06-01','10-B',5000.00,1),
(8,'Neha Desai','S008','2009-04-30','Female','246 Spruce Lane, Colombo','0718888888','Mohan Desai','0763333368','neha.d@example.com','2023-06-01','11-A',5500.00,1),
(9,'Rohit Iyer','S009','2008-09-12','Male','357 Walnut Street, Colombo','0719999999','Ramesh Iyer','0764444469','rohit.i@example.com','2023-06-01','9-A',5000.00,1),
(10,'Shreya Gupta','S010','2009-06-08','Female','468 Aspen Avenue, Colombo','0710000000','Sanjay Gupta','0765555570','shreya.g@example.com','2023-06-01','9-B',5000.00,1);

ALTER TABLE `Students` AUTO_INCREMENT = 11;

-- ==========================================
-- Classes
-- ==========================================
DROP TABLE IF EXISTS `Classes`;
CREATE TABLE `Classes` (
  `ClassID` INT NOT NULL AUTO_INCREMENT,
  `ClassName` VARCHAR(50) NOT NULL,
  `Section` VARCHAR(10) DEFAULT NULL,
  `ClassTeacherID` INT DEFAULT NULL,
  `ClassTeacherName` VARCHAR(100) DEFAULT NULL,
  `TotalStudents` INT DEFAULT 0,
  `Room` VARCHAR(20) DEFAULT NULL,
  `Schedule` VARCHAR(100) DEFAULT NULL,
  `CreatedDate` DATETIME DEFAULT CURRENT_TIMESTAMP,
  `IsActive` TINYINT(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`ClassID`),
  KEY `idx_class` (`ClassName`),
  KEY `idx_status` (`IsActive`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `Classes` (`ClassID`,`ClassName`,`Section`,`ClassTeacherID`,`ClassTeacherName`,`TotalStudents`,`Room`,`Schedule`,`IsActive`) VALUES
(1,'10-A','A',1,'Mr. John Doe',2,'101','08:00 AM - 12:00 PM',1),
(2,'10-B','B',2,'Mrs. Jane Smith',2,'102','08:00 AM - 12:00 PM',1),
(3,'9-A','A',3,'Mr. Robert Wilson',2,'103','08:00 AM - 12:00 PM',1),
(4,'9-B','B',5,'Mr. David Brown',2,'104','08:00 AM - 12:00 PM',1),
(5,'11-A','A',4,'Mrs. Emily Johnson',1,'105','01:00 PM - 05:00 PM',1);

ALTER TABLE `Classes` AUTO_INCREMENT = 6;

-- ==========================================
-- Attendance
-- ==========================================
DROP TABLE IF EXISTS `Attendance`;
CREATE TABLE `Attendance` (
  `AttendanceID` INT NOT NULL AUTO_INCREMENT,
  `StudentID` INT NOT NULL,
  `StudentName` VARCHAR(100) DEFAULT NULL,
  `AttendanceDate` DATETIME NOT NULL,
  `Status` VARCHAR(20) DEFAULT NULL,
  `Remarks` VARCHAR(200) DEFAULT NULL,
  `TeacherID` INT DEFAULT NULL,
  `CreatedDate` DATETIME DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`AttendanceID`),
  KEY `idx_student` (`StudentID`),
  KEY `idx_date` (`AttendanceDate`),
  KEY `idx_status` (`Status`),
  CONSTRAINT `fk_attendance_student` FOREIGN KEY (`StudentID`) REFERENCES `Students`(`StudentID`) ON DELETE CASCADE,
  CONSTRAINT `fk_attendance_teacher` FOREIGN KEY (`TeacherID`) REFERENCES `Teachers`(`TeacherID`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `Attendance` (`AttendanceID`,`StudentID`,`StudentName`,`AttendanceDate`,`Status`,`Remarks`,`TeacherID`) VALUES
(1,1,'Rajesh Kumar',NOW(),'Present','Regular',1),
(2,2,'Priya Sharma',NOW(),'Present','Regular',2),
(3,3,'Arjun Singh',NOW(),'Absent','Sick Leave',2),
(4,4,'Anaya Patel',NOW(),'Present','Regular',3),
(5,5,'Vikram Reddy',NOW(),'Late','Traffic',5);

ALTER TABLE `Attendance` AUTO_INCREMENT = 6;

-- ==========================================
-- ClassFees
-- ==========================================
DROP TABLE IF EXISTS `ClassFees`;
CREATE TABLE `ClassFees` (
  `FeeID` INT NOT NULL AUTO_INCREMENT,
  `StudentID` INT NOT NULL,
  `StudentName` VARCHAR(100) DEFAULT NULL,
  `Amount` DECIMAL(10,2) DEFAULT NULL,
  `DueDate` DATE DEFAULT NULL,
  `PaidDate` DATE DEFAULT NULL,
  `Status` VARCHAR(20) DEFAULT NULL,
  `Description` VARCHAR(200) DEFAULT NULL,
  `TeacherID` INT DEFAULT NULL,
  `CreatedDate` DATETIME DEFAULT CURRENT_TIMESTAMP,
  `UpdatedDate` DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`FeeID`),
  KEY `idx_student` (`StudentID`),
  KEY `idx_status` (`Status`),
  CONSTRAINT `fk_classfees_student` FOREIGN KEY (`StudentID`) REFERENCES `Students`(`StudentID`) ON DELETE CASCADE,
  CONSTRAINT `fk_classfees_teacher` FOREIGN KEY (`TeacherID`) REFERENCES `Teachers`(`TeacherID`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `ClassFees` (`FeeID`,`StudentID`,`StudentName`,`Amount`,`DueDate`,`PaidDate`,`Status`,`Description`,`TeacherID`) VALUES
(1,1,'Rajesh Kumar',5000.00,'2024-06-30','2024-06-15','Paid','June 2024 Fee',1),
(2,2,'Priya Sharma',5000.00,'2024-06-30',NULL,'Pending','June 2024 Fee',2),
(3,3,'Arjun Singh',5000.00,'2024-06-30','2024-06-20','Paid','June 2024 Fee',2),
(4,4,'Anaya Patel',5000.00,'2024-06-30',NULL,'Pending','June 2024 Fee',3),
(5,5,'Vikram Reddy',5000.00,'2024-06-30','2024-06-10','Paid','June 2024 Fee',5);

ALTER TABLE `ClassFees` AUTO_INCREMENT = 6;

-- ==========================================
-- ExamResults
-- ==========================================
DROP TABLE IF EXISTS `ExamResults`;
CREATE TABLE `ExamResults` (
  `ResultID` INT NOT NULL AUTO_INCREMENT,
  `StudentID` INT NOT NULL,
  `StudentName` VARCHAR(100) DEFAULT NULL,
  `ExamName` VARCHAR(100) DEFAULT NULL,
  `Subject` VARCHAR(50) DEFAULT NULL,
  `MarksObtained` DECIMAL(5,2) DEFAULT NULL,
  `TotalMarks` DECIMAL(5,2) DEFAULT NULL,
  `Percentage` DECIMAL(5,2) DEFAULT NULL,
  `Grade` VARCHAR(5) DEFAULT NULL,
  `ExamDate` DATE DEFAULT NULL,
  `TeacherID` INT DEFAULT NULL,
  `CreatedDate` DATETIME DEFAULT CURRENT_TIMESTAMP,
  `UpdatedDate` DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`ResultID`),
  KEY `idx_student` (`StudentID`),
  CONSTRAINT `fk_results_student` FOREIGN KEY (`StudentID`) REFERENCES `Students`(`StudentID`) ON DELETE CASCADE,
  CONSTRAINT `fk_results_teacher` FOREIGN KEY (`TeacherID`) REFERENCES `Teachers`(`TeacherID`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `ExamResults` (`ResultID`,`StudentID`,`StudentName`,`ExamName`,`Subject`,`MarksObtained`,`TotalMarks`,`Percentage`,`Grade`,`ExamDate`,`TeacherID`) VALUES
(1,1,'Rajesh Kumar','Midterm 2024','Mathematics',85.00,100.00,85.00,'A','2024-01-15',1),
(2,2,'Priya Sharma','Midterm 2024','English',92.00,100.00,92.00,'A+','2024-01-20',2),
(3,3,'Arjun Singh','Midterm 2024','Science',78.00,100.00,78.00,'B','2024-01-25',3),
(4,4,'Anaya Patel','Midterm 2024','Science',88.00,100.00,88.00,'A','2024-01-25',3),
(5,5,'Vikram Reddy','Midterm 2024','Geography',75.00,100.00,75.00,'B','2024-02-01',5);

ALTER TABLE `ExamResults` AUTO_INCREMENT = 6;

-- ==========================================
-- Notifications
-- ==========================================
DROP TABLE IF EXISTS `Notifications`;
CREATE TABLE `Notifications` (
  `NotificationID` INT NOT NULL AUTO_INCREMENT,
  `StudentID` INT NOT NULL,
  `StudentName` VARCHAR(100) DEFAULT NULL,
  `ParentEmail` VARCHAR(100) DEFAULT NULL,
  `ParentPhoneNumber` VARCHAR(15) DEFAULT NULL,
  `Message` TEXT DEFAULT NULL,
  `NotificationType` VARCHAR(50) DEFAULT NULL,
  `SentDate` DATETIME DEFAULT CURRENT_TIMESTAMP,
  `IsSent` TINYINT(1) NOT NULL DEFAULT 0,
  `TeacherID` INT DEFAULT NULL,
  `CreatedDate` DATETIME DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`NotificationID`),
  KEY `idx_student` (`StudentID`),
  CONSTRAINT `fk_notifications_student` FOREIGN KEY (`StudentID`) REFERENCES `Students`(`StudentID`) ON DELETE CASCADE,
  CONSTRAINT `fk_notifications_teacher` FOREIGN KEY (`TeacherID`) REFERENCES `Teachers`(`TeacherID`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `Notifications` (`NotificationID`,`StudentID`,`StudentName`,`ParentEmail`,`ParentPhoneNumber`,`Message`,`NotificationType`,`SentDate`,`IsSent`,`TeacherID`) VALUES
(1,1,'Rajesh Kumar','rajesh.p@example.com','0766666661','Your child is absent today','Attendance',NOW(),1,1),
(2,2,'Priya Sharma','priya.p@example.com','0767777762','Great performance in exam! Marks: 92/100','Exam Result',NOW(),1,2),
(3,3,'Arjun Singh','arjun.s@example.com','0768888863','Fee payment pending for June 2024','Fee Reminder',NOW(),1,2),
(4,4,'Anaya Patel','anaya.p@example.com','0769999964','Science exam scheduled for next Monday','Exam Schedule',NOW(),0,3),
(5,5,'Vikram Reddy','vikram.r@example.com','0760000065','Excellent participation in Geography class','General',NOW(),1,5);

ALTER TABLE `Notifications` AUTO_INCREMENT = 6;

-- ==========================================
-- Indexes for performance
-- ==========================================
CREATE INDEX IF NOT EXISTS `idx_teacher_email` ON `Teachers`(`Email`);
CREATE INDEX IF NOT EXISTS `idx_student_class` ON `Students`(`Class`);
CREATE INDEX IF NOT EXISTS `idx_attendance_teacher` ON `Attendance`(`TeacherID`);
CREATE INDEX IF NOT EXISTS `idx_fee_teacher` ON `ClassFees`(`TeacherID`);
CREATE INDEX IF NOT EXISTS `idx_exam_teacher` ON `ExamResults`(`TeacherID`);
CREATE INDEX IF NOT EXISTS `idx_notification_teacher` ON `Notifications`(`TeacherID`);
CREATE INDEX IF NOT EXISTS `idx_class_teacher` ON `Classes`(`ClassTeacherID`);

-- ==========================================
-- Done
-- Import this file in phpMyAdmin
-- ==========================================

SELECT 'OK' AS Status;
