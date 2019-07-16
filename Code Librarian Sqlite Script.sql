-- Code Librarian SQLite Script
-- This script was used to create the database. It's not pure SQLite, but this was intentional.

CREATE TABLE "Language" (
	"LanguageId"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"Name"			NVARCHAR(30) NOT NULL UNIQUE
);

CREATE UNIQUE INDEX "ix_language_name" ON "Language" (
	"Name"
);

CREATE TABLE "Author" (
	"AuthorId"		INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"Name"			NVARCHAR(60) NOT NULL UNIQUE,
	"ContactInfo"	NVARCHAR(254) NOT NULL
);

CREATE UNIQUE INDEX "ix_author_name" ON "Author" (
	"Name"
);

CREATE TABLE "Snippet" (
	"SnippetId"		INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"AuthorId"		INTEGER NOT NULL,
	"Title"			NVARCHAR(50) NOT NULL,
	"Purpose"		NVARCHAR(255) NOT NULL,
	"DateCreated"	DATETIME NOT NULL,
	"DateUpdated"	DATETIME NOT NULL,
	"Version"		NVARCHAR(8) NOT NULL,
	"LanguageId"	INTEGER NOT NULL,
	"Keywords"		NVARCHAR(255) NOT NULL,
	"CodeSnippet"	NVARCHAR(60000) NOT NULL,
	FOREIGN KEY("AuthorId") REFERENCES "Author"("AuthorId") 
		ON DELETE NO ACTION 
		ON UPDATE CASCADE,
	FOREIGN KEY("LanguageId") REFERENCES "Language"("LanguageId") 
		ON DELETE NO ACTION 
		ON UPDATE CASCADE
);

CREATE UNIQUE INDEX "ix_snippet_title_language" ON "Snippet" (
	"Title",
	"LanguageId"
);