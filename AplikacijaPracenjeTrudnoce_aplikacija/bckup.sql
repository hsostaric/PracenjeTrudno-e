CREATE TABLE "kalendar" (
  "ID" int4 NOT NULL DEFAULT nextval('"kalendar_ID_seq"'::regclass),
  "pocetak" timestamp(6) NOT NULL,
  "zavrsetak" timestamp(6) NOT NULL,
  "pregled_id" int4 NOT NULL,
  CONSTRAINT "_copy_5" PRIMARY KEY ("ID")
);
ALTER TABLE "kalendar" OWNER TO "postgres";
CREATE TRIGGER "trigger_validacija_radnog_vreeman" BEFORE INSERT ON "kalendar"
FOR EACH ROW
EXECUTE PROCEDURE "public"."provjera_radnog_vremena"();

CREATE TABLE "lijecnik" (
  "ID" int4 NOT NULL DEFAULT nextval('"lijecnik_ID_seq"'::regclass),
  "ime" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "prezime" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "kontakt" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "zvanje_id" int4,
  "adresa" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  CONSTRAINT "_copy_4" PRIMARY KEY ("ID")
);
ALTER TABLE "lijecnik" OWNER TO "postgres";

CREATE TABLE "pregled" (
  "ID" int4 NOT NULL DEFAULT nextval('"pregled_ID_seq"'::regclass),
  "datum_pregleda" date,
  "opis" varchar(255) COLLATE "pg_catalog"."default",
  "vrsta_id" int4 NOT NULL,
  "lijecnik_id" int4 NOT NULL,
  "trudnica_id" int4 NOT NULL,
  CONSTRAINT "_copy_1" PRIMARY KEY ("ID")
);
ALTER TABLE "pregled" OWNER TO "postgres";
CREATE TRIGGER "trigger_rezervacija_termina" AFTER INSERT ON "pregled"
FOR EACH ROW
EXECUTE PROCEDURE "public"."automatsko_popunjavanje_termina"();

CREATE TABLE "rezultati_dijete" (
  "pregled_id" int4 NOT NULL,
  "otkucaji_srca" int4,
  "velicina" numeric(255),
  "udaljenost_fundusa" numeric(255),
  "opseg_glavice" numeric(255),
  "opseg_tijela" numeric(255),
  CONSTRAINT "rezultati_dijete_pkey" PRIMARY KEY ("pregled_id")
);
ALTER TABLE "rezultati_dijete" OWNER TO "postgres";

CREATE TABLE "rezultati_trudnica" (
  "pregled_id" int4 NOT NULL,
  "tjelesna_tezina" numeric(255),
  "rh_faktor" varchar(255) COLLATE "pg_catalog"."default",
  "krvna_grupa" varchar(255) COLLATE "pg_catalog"."default",
  "krvni_tlak" varchar(255) COLLATE "pg_catalog"."default",
  CONSTRAINT "rezultati_trudnica_pkey" PRIMARY KEY ("pregled_id")
);
ALTER TABLE "rezultati_trudnica" OWNER TO "postgres";

CREATE TABLE "trudnica" (
  "ID" int4 NOT NULL DEFAULT nextval('"trudnica_ID_seq"'::regclass),
  "username" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "password" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "ime" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "prezime" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "email" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "datumrodjenja" date,
  "kontakt" varchar(255) COLLATE "pg_catalog"."default",
  CONSTRAINT "trudnica_pkey" PRIMARY KEY ("ID")
);
ALTER TABLE "trudnica" OWNER TO "postgres";

CREATE TABLE "trudnoca" (
  "ID" int4 NOT NULL DEFAULT nextval('"trudnoca_ID_seq"'::regclass),
  "trudnica_id" int4 NOT NULL,
  "vrijeme_zaceca" date NOT NULL,
  "termin_rodjenja" date,
  CONSTRAINT "_copy_6" PRIMARY KEY ("ID")
);
ALTER TABLE "trudnoca" OWNER TO "postgres";
CREATE TRIGGER "trigger_provjera_trudnoce" BEFORE INSERT OR UPDATE ON "trudnoca"
FOR EACH ROW
EXECUTE PROCEDURE "public"."provjera_trenutne_trudnoce"();

CREATE TABLE "vrsta_pregleda" (
  "ID" int4 NOT NULL DEFAULT nextval('"vrsta_pregleda_ID_seq"'::regclass),
  "naziv" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "trajanje" int4,
  CONSTRAINT "_copy_2" PRIMARY KEY ("ID")
);
ALTER TABLE "vrsta_pregleda" OWNER TO "postgres";

CREATE TABLE "zvanje" (
  "ID" int4 NOT NULL DEFAULT nextval('"zvanje_ID_seq"'::regclass),
  "naziv" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "opis" varchar(255) COLLATE "pg_catalog"."default",
  CONSTRAINT "_copy_3" PRIMARY KEY ("ID")
);
ALTER TABLE "zvanje" OWNER TO "postgres";

ALTER TABLE "kalendar" ADD CONSTRAINT "fk_kalendar_pregled_1" FOREIGN KEY ("pregled_id") REFERENCES "pregled" ("ID") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "lijecnik" ADD CONSTRAINT "fk_lijecnik_zvanje_1" FOREIGN KEY ("zvanje_id") REFERENCES "zvanje" ("ID") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "pregled" ADD CONSTRAINT "fk_pregled_lijecnik_1" FOREIGN KEY ("lijecnik_id") REFERENCES "lijecnik" ("ID") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "pregled" ADD CONSTRAINT "fk_pregled_trudnica_1" FOREIGN KEY ("trudnica_id") REFERENCES "trudnica" ("ID") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "pregled" ADD CONSTRAINT "fk_pregled_vrsta_pregleda_1" FOREIGN KEY ("vrsta_id") REFERENCES "vrsta_pregleda" ("ID") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "rezultati_dijete" ADD CONSTRAINT "fk_rezultati_dijete_pregled_1" FOREIGN KEY ("pregled_id") REFERENCES "pregled" ("ID") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "rezultati_trudnica" ADD CONSTRAINT "fk_rezultati_trudnica_pregled_1" FOREIGN KEY ("pregled_id") REFERENCES "pregled" ("ID") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "trudnoca" ADD CONSTRAINT "fk_trudnoca_trudnica_1" FOREIGN KEY ("trudnica_id") REFERENCES "trudnica" ("ID") ON DELETE NO ACTION ON UPDATE NO ACTION;

