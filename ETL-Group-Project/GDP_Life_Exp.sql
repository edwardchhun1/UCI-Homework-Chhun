create table GDP (
	id SERIAL PRIMARY KEY,
	"Country Name" VARCHAR not NULL,
	"Country Code" VARCHAR(5) not NULL,
	"2008" VARCHAR(100),
	"2009" VARCHAR(100),
	"2010" VARCHAR(100),
	"2011" VARCHAR(100)
);

create table life_expectancy (
	id SERIAL PRIMARY KEY,
	"Country Name" VARCHAR not NULL,
	"Country Code" VARCHAR(5) not NULL,
	"2008" VARCHAR(100),
	"2009" VARCHAR(100),
	"2010" VARCHAR(100),
	"2011" VARCHAR(100)
);

create table GDP_Life (
	id SERIAL PRIMARY KEY,
	"Country Name" VARCHAR not NULL,
	"Country Code" VARCHAR(5) not NULL,
	"2008 GDP (Dollars)" VARCHAR(100), 
    "2009 GDP (Dollars)" VARCHAR(100),
    "2010 GDP (Dollars)" VARCHAR(100),
	"2011 GDP (Dollars)" VARCHAR(100)
);