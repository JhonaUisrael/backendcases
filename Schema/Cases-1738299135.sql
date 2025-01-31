CREATE TABLE [Person] (
	[personId] int IDENTITY(1,1) NOT NULL UNIQUE,
	[personName] nvarchar(100),
	[personLastName] nvarchar(100),
	[personIdentification] nvarchar(14),
	[createdAt] datetime NOT NULL DEFAULT 'getDate()',
	[active] nvarchar(max) NOT NULL DEFAULT 1,
	[personTypeId] int NOT NULL,
	PRIMARY KEY ([personId])
);

CREATE TABLE [PersonType] (
	[personTypeId] int IDENTITY(1,1) NOT NULL UNIQUE,
	[personTypeName] nvarchar(max),
	[createdAt] datetime NOT NULL DEFAULT 'getDate()',
	[active] nvarchar(max) NOT NULL DEFAULT 1,
	PRIMARY KEY ([personTypeId])
);

CREATE TABLE [Cases] (
	[caseId] int IDENTITY(1,1) NOT NULL UNIQUE,
	[caseNumber] nvarchar(100) NOT NULL,
	[caseDescription] nvarchar(500),
	[caseTypeId] int NOT NULL,
	[caseStartDate] datetime NOT NULL,
	[caseEndDate] datetime NOT NULL,
	[casePriority] nvarchar(50) NOT NULL,
	[personId] int,
	[caseState] nvarchar(max) DEFAULT '30',
	[createdAt] datetime NOT NULL DEFAULT 'getDate()',
	[active] nvarchar(max) NOT NULL DEFAULT 1,
	PRIMARY KEY ([caseId])
);

CREATE TABLE [CasesType] (
	[caseTypeId] int IDENTITY(1,1) NOT NULL UNIQUE,
	[caseName] nvarchar(max) NOT NULL DEFAULT '100',
	[created] datetime NOT NULL DEFAULT 'getDate()',
	[active] nvarchar(max) NOT NULL DEFAULT 1,
	PRIMARY KEY ([caseTypeId])
);

CREATE TABLE [TaskCase] (
	[taskId] int IDENTITY(1,1) NOT NULL UNIQUE,
	[taskDetail] nvarchar(200) NOT NULL,
	[caseId] int NOT NULL,
	[taskState] nvarchar(50) NOT NULL,
	[createdAt] int NOT NULL,
	[active] nvarchar(max) NOT NULL DEFAULT 1,
	PRIMARY KEY ([taskId])
);

ALTER TABLE [Person] ADD CONSTRAINT [Person_fk6] FOREIGN KEY ([personTypeId]) REFERENCES [PersonType]([personTypeId]);

ALTER TABLE [Cases] ADD CONSTRAINT [Cases_fk3] FOREIGN KEY ([caseTypeId]) REFERENCES [CasesType]([caseTypeId]);

ALTER TABLE [Cases] ADD CONSTRAINT [Cases_fk7] FOREIGN KEY ([personId]) REFERENCES [Person]([personId]);

ALTER TABLE [TaskCase] ADD CONSTRAINT [TaskCase_fk2] FOREIGN KEY ([caseId]) REFERENCES [Cases]([caseId]);