-- Exported from QuickDBD: https://www.quickdatabasediagrams.com/
-- NOTE! If you have used non-SQL datatypes in your design, you will have to change these here.


CREATE TABLE "GDP" (
    "2008" VARCHAR(100)   NOT NULL,
    "2009" VARCHAR(100)   NOT NULL,
    "2010" VARCHAR(100)   NOT NULL,
    "2011" VARCHAR(100)   NOT NULL,
    "id" serial   NOT NULL,
    "Country Name" VARCHAR(60)   NOT NULL,
    "Country Code" VARCHAR(10)   NOT NULL,
    CONSTRAINT "pk_GDP" PRIMARY KEY (
        "id"
     )
);

CREATE TABLE "life_expectancy" (
    "2008" VARCHAR(100)   NOT NULL,
    "2009" VARCHAR(100)   NOT NULL,
    "2010" VARCHAR(100)   NOT NULL,
    "2011" VARCHAR(100)   NOT NULL,
    "id" serial   NOT NULL,
    "Country Name" VARCHAR(50)   NOT NULL,
    "Country Code" VARCHAR(10)   NOT NULL,
    CONSTRAINT "pk_life_expectancy" PRIMARY KEY (
        "id"
     )
);

CREATE TABLE "GDP_Life" (
    "id" serial   NOT NULL,
    "Country Name" VARCHAR(50)   NOT NULL,
    "Country Code" VARCHAR(10)   NOT NULL,
    "2008 GDP (Dollars)" VARCHAR(100)   NOT NULL,
    "2009 GDP (Dollars)" VARCHAR(100)   NOT NULL,
    "2010 GDP (Dollars)" VARCHAR(100)   NOT NULL,
    "2011 GDP (Dollars)" VARCHAR(100)   NOT NULL,
    CONSTRAINT "pk_GDP_Life" PRIMARY KEY (
        "id"
     )
);

