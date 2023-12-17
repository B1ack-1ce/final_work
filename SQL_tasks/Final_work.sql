DROP DATABASE IF EXISTS Registry;

CREATE DATABASE IF NOT EXISTS Registry;

USE Registry;

CREATE TABLE Commands
(
  id INT NOT NULL AUTO_INCREMENT,
  command_name VARCHAR(45) NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE Classes
(
  id INT NOT NULL AUTO_INCREMENT,
  class_name VARCHAR(45) NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE Animals
(
  id INT NOT NULL AUTO_INCREMENT,
  name VARCHAR(45) NOT NULL,
  birthday DATE NOT NULL,
  type VARCHAR(45) NOT NULL,
  commands VARCHAR(45),
  class INT NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (class) REFERENCES Classes(id)
);

CREATE TABLE Animals_commands
(
  command_id INT NOT NULL,
  animal_id INT NOT NULL,
  FOREIGN KEY (command_id) REFERENCES Commands(id),
  FOREIGN KEY (animal_id) REFERENCES Animals(id)
);
