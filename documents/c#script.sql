#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: club
#------------------------------------------------------------

CREATE TABLE club(
        id_club          int (11) Auto_increment  NOT NULL ,
        Titre_club       Varchar (50) ,
        url_club         Varchar (50) ,
        Adresse_club     Varchar (50) ,
        Code_Postal_club Varchar (25) ,
        Ville_club       Varchar (50) ,
        mail_club        Varchar (50) ,
        telephone_club   Varchar (10) ,
        PRIMARY KEY (id_club ) ,
        UNIQUE (Titre_club )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: adherent
#------------------------------------------------------------

CREATE TABLE adherent(
        id_adherent             int (11) Auto_increment  NOT NULL ,
        numero_licence          Varchar (12) NOT NULL ,
        Nom_adherent            Varchar (25) NOT NULL ,
        Prenom_adherent         Varchar (25) ,
        Date_naissance_adherent Date ,
        Adresse_adherent        Varchar (50) ,
        Code_Postal_adherent    Varchar (25) ,
        Ville_adherent          Varchar (50) ,
        cotisation_adherent     Int ,
        PRIMARY KEY (id_adherent ) ,
        UNIQUE (numero_licence )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: evenement
#------------------------------------------------------------

CREATE TABLE evenement(
        id_evenement    int (11) Auto_increment  NOT NULL ,
        Titre_evenement Varchar (50) ,
        debut_evenement Date ,
        fin_evenement   Date ,
        id_club         Int ,
        PRIMARY KEY (id_evenement ) ,
        UNIQUE (Titre_evenement )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: adherer
#------------------------------------------------------------

CREATE TABLE adherer(
        id_adherent Int NOT NULL ,
        id_club     Int NOT NULL ,
        PRIMARY KEY (id_adherent ,id_club )
)ENGINE=InnoDB;

ALTER TABLE evenement ADD CONSTRAINT FK_evenement_id_club FOREIGN KEY (id_club) REFERENCES club(id_club);
ALTER TABLE adherer ADD CONSTRAINT FK_adherer_id_adherent FOREIGN KEY (id_adherent) REFERENCES adherent(id_adherent);
ALTER TABLE adherer ADD CONSTRAINT FK_adherer_id_club FOREIGN KEY (id_club) REFERENCES club(id_club);
