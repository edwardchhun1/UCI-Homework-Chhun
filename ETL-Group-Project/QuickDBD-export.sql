-- Exported from QuickDBD: https://www.quickdatabasediagrams.com/
-- NOTE! If you have used non-SQL datatypes in your design, you will have to change these here.


CREATE TABLE "GDP" (
    "2008" VARCHAR(100)   NOT NULL,
    "2009" VARCHAR(100)   NOT NULL,
    "2010" VARCHAR(100)   NOT NULL,
    "2011" VARCHAR(100)   NOT NULL,
    "id" serial   NOT NULL,
    "Country Name" VARCHAR(60)   NOT NULL,
    "Country Code" VARCHAR(6)   NOT NULL,
    CONSTRAINT "pk_GDP" PRIMARY KEY (
        "id"
     )
);

CREATE TABLE "Life_Expectancy" (
    "2008" VARCHAR(100)   NOT NULL,
    "2009" VARCHAR(100)   NOT NULL,
    "2010" VARCHAR(100)   NOT NULL,
    "2011" VARCHAR(100)   NOT NULL,
    "id" serial   NOT NULL,
    "Country Name" VARCHAR(60)   NOT NULL,
    "Country Code" VARCHAR(6)   NOT NULL,
    CONSTRAINT "pk_Life_Expectancy" PRIMARY KEY (
        "id"
     )
);

CREATE TABLE "GDP_Life" (
    "id" serial   NOT NULL,
    "Country Name" VARCHAR(60)   NOT NULL,
    "Country Code" VARCHAR(6)   NOT NULL,
    "2008 GDP in Dollars" VARCHAR(100)   NOT NULL,
    "2009 GDP in Dollars" VARCHAR(100)   NOT NULL,
    "2010 GDP in Dollars" VARCHAR(100)   NOT NULL,
    "2011 GDP in Dollars" VARCHAR(100)   NOT NULL,
    "2008 Life Expectancy in Years" VARCHAR(100)   NOT NULL,
    "2009 Life_Expectancy in Years" VARCHAR(100)   NOT NULL,
    "2010 Life_Expectancy in Years" VARCHAR(100)   NOT NULL,
    "2011 Life_Expectancy in Years" VARCHAR(100)   NOT NULL,
    CONSTRAINT "pk_GDP_Life" PRIMARY KEY (
        "id"
     )
);

ALTER TABLE "GDP" ADD CONSTRAINT "fk_GDP_2011" FOREIGN KEY("2011")
REFERENCES "Life_Expectancy" ("2011");

ALTER TABLE "Life_Expectancy" ADD CONSTRAINT "fk_Life_Expectancy_2010" FOREIGN KEY("2010")
REFERENCES "GDP_Life" ("Country Name");

