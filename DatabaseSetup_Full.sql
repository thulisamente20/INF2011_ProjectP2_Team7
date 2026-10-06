-- =====================================================================
-- Future Path Student Advising System - DatabaseSetup_Full.sql
-- Safe to re-run: drops every table first (children before parents),
-- then recreates them. WARNING: re-running wipes all data, so run
-- SeedData.sql again afterwards.
-- =====================================================================

IF DB_ID('FuturePathDB') IS NULL
    CREATE DATABASE FuturePathDB;
GO

USE FuturePathDB;
GO

-- ---------------------------------------------------------------------
-- 1. DROP TABLES (children first, parents last)
--    Rule: when you add a table, add its drop line ABOVE its parents.
-- ---------------------------------------------------------------------
IF OBJECT_ID('ExportReport',            'U') IS NOT NULL DROP TABLE ExportReport;
IF OBJECT_ID('FundingProgramme',        'U') IS NOT NULL DROP TABLE FundingProgramme;
IF OBJECT_ID('FundingFaculty',          'U') IS NOT NULL DROP TABLE FundingFaculty;
IF OBJECT_ID('Funding',                 'U') IS NOT NULL DROP TABLE Funding;
IF OBJECT_ID('RecommendationResult',    'U') IS NOT NULL DROP TABLE RecommendationResult;
IF OBJECT_ID('AdvisorySession',         'U') IS NOT NULL DROP TABLE AdvisorySession;
IF OBJECT_ID('DegreeInterestMapping',   'U') IS NOT NULL DROP TABLE DegreeInterestMapping;
IF OBJECT_ID('ProgrammeRequirement',    'U') IS NOT NULL DROP TABLE ProgrammeRequirement;
IF OBJECT_ID('LearnerInterestResponse', 'U') IS NOT NULL DROP TABLE LearnerInterestResponse;
IF OBJECT_ID('InterestQuestion',        'U') IS NOT NULL DROP TABLE InterestQuestion;
IF OBJECT_ID('InterestCategory',        'U') IS NOT NULL DROP TABLE InterestCategory;
IF OBJECT_ID('LearnerSubject',          'U') IS NOT NULL DROP TABLE LearnerSubject;
IF OBJECT_ID('Learner',                 'U') IS NOT NULL DROP TABLE Learner;
IF OBJECT_ID('Degree',                  'U') IS NOT NULL DROP TABLE Degree;
IF OBJECT_ID('Subject',                 'U') IS NOT NULL DROP TABLE Subject;
IF OBJECT_ID('GradeLevel',              'U') IS NOT NULL DROP TABLE GradeLevel;
IF OBJECT_ID('Faculty',                 'U') IS NOT NULL DROP TABLE Faculty;
IF OBJECT_ID('UserAccount',             'U') IS NOT NULL DROP TABLE UserAccount;
GO

-- ---------------------------------------------------------------------
-- 2. CREATE TABLES (parents first, children last)
-- ---------------------------------------------------------------------

-- Logins for Administrators and Career Advisors
CREATE TABLE UserAccount (
    UserId        INT IDENTITY(1,1) PRIMARY KEY,
    Username      NVARCHAR(100) NOT NULL UNIQUE,
    PasswordHash  NVARCHAR(255) NOT NULL,
    Role          NVARCHAR(50)  NOT NULL,
    IsActive      BIT           NOT NULL DEFAULT 1,
    CONSTRAINT CK_UserAccount_Role CHECK (Role IN ('Admin', 'Advisor'))
);

-- Faculties (Commerce, Science, ...)
CREATE TABLE Faculty (
    FacultyId    INT IDENTITY(1,1) PRIMARY KEY,
    FacultyName  NVARCHAR(100) NOT NULL UNIQUE,
    IsActive     BIT           NOT NULL DEFAULT 1
);

-- Grade 11 / Grade 12 (the key IS the grade number, so Learner.Grade = 11 or 12)
CREATE TABLE GradeLevel (
    GradeLevelId  INT PRIMARY KEY,
    GradeName     NVARCHAR(20) NOT NULL
);

-- School subjects
CREATE TABLE Subject (
    SubjectId    INT IDENTITY(1,1) PRIMARY KEY,
    SubjectName  NVARCHAR(150) NOT NULL,
    Code         NVARCHAR(50)  NOT NULL UNIQUE,
    Credits      INT           NOT NULL DEFAULT 0,
    IsActive     BIT           NOT NULL DEFAULT 1
);

-- Degree programmes (each belongs to a valid faculty)
CREATE TABLE Degree (
    DegreeId     INT IDENTITY(1,1) PRIMARY KEY,
    DegreeName   NVARCHAR(150) NOT NULL,
    FacultyId    INT           NOT NULL,
    Description  NVARCHAR(500) NULL,
    IsActive     BIT           NOT NULL DEFAULT 1,
    CONSTRAINT FK_Degree_Faculty FOREIGN KEY (FacultyId) REFERENCES Faculty(FacultyId)
);

-- Learner profile (name etc. optional for privacy)
CREATE TABLE Learner (
    LearnerId       INT IDENTITY(1,1) PRIMARY KEY,
    Name            NVARCHAR(100) NULL,
    School          NVARCHAR(150) NULL,
    Province        NVARCHAR(50)  NULL,
    ContactDetails  NVARCHAR(150) NULL,
    Grade           INT           NOT NULL,
    CreatedDate     DATETIME2     NOT NULL DEFAULT SYSDATETIME(),
    CONSTRAINT FK_Learner_GradeLevel FOREIGN KEY (Grade) REFERENCES GradeLevel(GradeLevelId)
);

-- One row per subject a learner takes, with the mark
CREATE TABLE LearnerSubject (
    LearnerSubjectId  INT IDENTITY(1,1) PRIMARY KEY,
    LearnerId         INT          NOT NULL,
    SubjectId         INT          NOT NULL,
    Mark              DECIMAL(5,2) NOT NULL,
    CONSTRAINT FK_LearnerSubject_Learner FOREIGN KEY (LearnerId) REFERENCES Learner(LearnerId),
    CONSTRAINT FK_LearnerSubject_Subject FOREIGN KEY (SubjectId) REFERENCES Subject(SubjectId),
    CONSTRAINT CK_LearnerSubject_Mark    CHECK (Mark BETWEEN 0 AND 100),
    CONSTRAINT UQ_LearnerSubject         UNIQUE (LearnerId, SubjectId)   -- no duplicate subjects
);

-- Broad interest areas (at least 5 needed)
CREATE TABLE InterestCategory (
    CategoryId    INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName  NVARCHAR(100) NOT NULL UNIQUE
);

-- Questionnaire questions (each question feeds one interest category)
CREATE TABLE InterestQuestion (
    QuestionId    INT IDENTITY(1,1) PRIMARY KEY,
    QuestionText  NVARCHAR(300) NOT NULL,
    CategoryId    INT           NOT NULL,
    IsActive      BIT           NOT NULL DEFAULT 1,
    CONSTRAINT FK_InterestQuestion_Category FOREIGN KEY (CategoryId) REFERENCES InterestCategory(CategoryId)
);

-- Learner answers: 1 = Dislike, 2 = Neutral, 3 = Like
CREATE TABLE LearnerInterestResponse (
    ResponseId  INT IDENTITY(1,1) PRIMARY KEY,
    LearnerId   INT     NOT NULL,
    QuestionId  INT     NOT NULL,
    Response    TINYINT NOT NULL,
    CONSTRAINT FK_LIR_Learner  FOREIGN KEY (LearnerId)  REFERENCES Learner(LearnerId),
    CONSTRAINT FK_LIR_Question FOREIGN KEY (QuestionId) REFERENCES InterestQuestion(QuestionId),
    CONSTRAINT CK_LIR_Response CHECK (Response IN (1, 2, 3)),
    CONSTRAINT UQ_LIR          UNIQUE (LearnerId, QuestionId)
);

-- Subject/mark requirements per degree.
-- AlternativeSubjectId handles e.g. Mathematics OR Mathematical Literacy.
CREATE TABLE ProgrammeRequirement (
    RequirementId        INT IDENTITY(1,1) PRIMARY KEY,
    DegreeId             INT          NOT NULL,
    SubjectId            INT          NOT NULL,
    MinMark              DECIMAL(5,2) NOT NULL,
    AlternativeSubjectId INT          NULL,
    AlternativeMinMark   DECIMAL(5,2) NULL,
    AdvisoryNote         NVARCHAR(500) NULL,
    CONSTRAINT FK_ProgReq_Degree  FOREIGN KEY (DegreeId)             REFERENCES Degree(DegreeId),
    CONSTRAINT FK_ProgReq_Subject FOREIGN KEY (SubjectId)            REFERENCES Subject(SubjectId),
    CONSTRAINT FK_ProgReq_AltSubj FOREIGN KEY (AlternativeSubjectId) REFERENCES Subject(SubjectId),
    CONSTRAINT CK_ProgReq_Min     CHECK (MinMark BETWEEN 0 AND 100),
    CONSTRAINT CK_ProgReq_AltMin  CHECK (AlternativeMinMark BETWEEN 0 AND 100),
    CONSTRAINT UQ_ProgReq         UNIQUE (DegreeId, SubjectId)
);

-- Links degrees to interest categories (each degree needs at least one)
CREATE TABLE DegreeInterestMapping (
    DegreeId    INT NOT NULL,
    CategoryId  INT NOT NULL,
    CONSTRAINT PK_DegreeInterestMapping PRIMARY KEY (DegreeId, CategoryId),
    CONSTRAINT FK_DIM_Degree   FOREIGN KEY (DegreeId)   REFERENCES Degree(DegreeId),
    CONSTRAINT FK_DIM_Category FOREIGN KEY (CategoryId) REFERENCES InterestCategory(CategoryId)
);

-- One advising session per learner run, with the final outcome
CREATE TABLE AdvisorySession (
    SessionId         INT IDENTITY(1,1) PRIMARY KEY,
    LearnerId         INT           NOT NULL,
    DegreeId          INT           NOT NULL,
    SessionDate       DATETIME2     NOT NULL DEFAULT SYSDATETIME(),
    Outcome           NVARCHAR(30)  NOT NULL,
    OutcomeReason     NVARCHAR(1000) NOT NULL,
    InterestScore     DECIMAL(5,2)  NULL,
    OverallScore      DECIMAL(5,2)  NULL,
    FundingRequested  BIT           NOT NULL DEFAULT 0,
    CONSTRAINT FK_Session_Learner FOREIGN KEY (LearnerId) REFERENCES Learner(LearnerId),
    CONSTRAINT FK_Session_Degree  FOREIGN KEY (DegreeId)  REFERENCES Degree(DegreeId),
    CONSTRAINT CK_Session_Outcome CHECK (Outcome IN
        ('Strong Match', 'Possible Match', 'Not Currently Eligible', 'More Information Needed'))
);

-- Ranked alternative degrees for a session
CREATE TABLE RecommendationResult (
    ResultId       INT IDENTITY(1,1) PRIMARY KEY,
    SessionId      INT          NOT NULL,
    DegreeId       INT          NOT NULL,
    OverallScore   DECIMAL(5,2) NOT NULL,
    RankPosition   INT          NOT NULL,
    GapSummary     NVARCHAR(500) NULL,
    CONSTRAINT FK_RecResult_Session FOREIGN KEY (SessionId) REFERENCES AdvisorySession(SessionId),
    CONSTRAINT FK_RecResult_Degree  FOREIGN KEY (DegreeId)  REFERENCES Degree(DegreeId)
);

-- Funding opportunities (sample data, not live)
CREATE TABLE Funding (
    FundingId          INT IDENTITY(1,1) PRIMARY KEY,
    FundingName        NVARCHAR(150) NOT NULL,
    Provider           NVARCHAR(150) NOT NULL,
    Amount             DECIMAL(18,2) NOT NULL DEFAULT 0,
    Criteria           NVARCHAR(500) NULL,         -- eligibility description
    FundingType        NVARCHAR(50)  NOT NULL,
    RequiredDocuments  NVARCHAR(300) NULL,
    ClosingDate        DATE          NULL,
    ContactInfo        NVARCHAR(200) NULL,
    IsSampleData       BIT           NOT NULL DEFAULT 1,
    IsActive           BIT           NOT NULL DEFAULT 1,
    CONSTRAINT CK_Funding_Type CHECK (FundingType IN
        ('Scholarship', 'Bursary', 'Financial Aid', 'Merit Award', 'External Funding'))
);

-- Which faculties a funding option applies to
CREATE TABLE FundingFaculty (
    FundingId  INT NOT NULL,
    FacultyId  INT NOT NULL,
    CONSTRAINT PK_FundingFaculty PRIMARY KEY (FundingId, FacultyId),
    CONSTRAINT FK_FF_Funding FOREIGN KEY (FundingId) REFERENCES Funding(FundingId),
    CONSTRAINT FK_FF_Faculty FOREIGN KEY (FacultyId) REFERENCES Faculty(FacultyId)
);

-- Which specific degrees a funding option applies to (optional)
CREATE TABLE FundingProgramme (
    FundingId  INT NOT NULL,
    DegreeId   INT NOT NULL,
    CONSTRAINT PK_FundingProgramme PRIMARY KEY (FundingId, DegreeId),
    CONSTRAINT FK_FP_Funding FOREIGN KEY (FundingId) REFERENCES Funding(FundingId),
    CONSTRAINT FK_FP_Degree  FOREIGN KEY (DegreeId)  REFERENCES Degree(DegreeId)
);

-- Audit log of every exported summary
CREATE TABLE ExportReport (
    ExportId          INT IDENTITY(1,1) PRIMARY KEY,
    SessionId         INT          NOT NULL,
    ExportedOn        DATETIME2    NOT NULL DEFAULT SYSDATETIME(),
    ExportFormat      NVARCHAR(20) NOT NULL,
    ExportedByUserId  INT          NULL,   -- NULL when a learner exports
    CONSTRAINT FK_Export_Session FOREIGN KEY (SessionId)        REFERENCES AdvisorySession(SessionId),
    CONSTRAINT FK_Export_User    FOREIGN KEY (ExportedByUserId) REFERENCES UserAccount(UserId)
);
GO

-- ---------------------------------------------------------------------
-- 3. REFERENCE ROWS THE APP CANNOT RUN WITHOUT
-- ---------------------------------------------------------------------
INSERT INTO GradeLevel (GradeLevelId, GradeName) VALUES (11, 'Grade 11'), (12, 'Grade 12');

-- Test logins (one active Admin + one active Advisor are required).
-- NOTE: stored as plain text until Member A's login code hashes passwords.
-- When hashing is added, replace these with the hashed values.
INSERT INTO UserAccount (Username, PasswordHash, Role)
VALUES ('admin_user',   'Admin123',   'Admin'),
       ('advisor_user', 'Advisor123', 'Advisor');
GO
