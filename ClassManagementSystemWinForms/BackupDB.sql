--
-- PostgreSQL database dump
--

-- Dumped from database version 15.0
-- Dumped by pg_dump version 15.0

-- Started on 2022-11-21 07:47:17

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

DROP DATABASE "ClassManagementSystem";
--
-- TOC entry 3358 (class 1262 OID 16527)
-- Name: ClassManagementSystem; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE "ClassManagementSystem" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_Indonesia.1252';


ALTER DATABASE "ClassManagementSystem" OWNER TO postgres;

\connect "ClassManagementSystem"

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 214 (class 1259 OID 16536)
-- Name: Admin; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Admin" (
    "Id" integer NOT NULL,
    "Name" character varying(255),
    "Username" character varying(255) NOT NULL,
    "NIP" integer,
    "Jabatan" character varying(255),
    "Password" character varying(255) NOT NULL
);


ALTER TABLE public."Admin" OWNER TO postgres;

--
-- TOC entry 221 (class 1259 OID 16589)
-- Name: Admin_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public."Admin" ALTER COLUMN "Id" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Admin_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 217 (class 1259 OID 16551)
-- Name: Course; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Course" (
    "Id" integer NOT NULL,
    "Code" character varying(255) NOT NULL,
    "Name" character varying(255),
    "Description" character varying(255),
    "Lecturer" character varying(255),
    "Day" character varying(255) NOT NULL,
    "StartTime" time without time zone NOT NULL,
    "Room" character varying(255)
);


ALTER TABLE public."Course" OWNER TO postgres;

--
-- TOC entry 216 (class 1259 OID 16550)
-- Name: Course_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public."Course" ALTER COLUMN "Id" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Course_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 215 (class 1259 OID 16543)
-- Name: Student; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Student" (
    "Id" integer NOT NULL,
    "Name" character varying(255),
    "Username" character varying(255) NOT NULL,
    "NIU" integer,
    "Prodi" character varying(255),
    "Password" character varying(255) NOT NULL
);


ALTER TABLE public."Student" OWNER TO postgres;

--
-- TOC entry 218 (class 1259 OID 16564)
-- Name: StudentCourse; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."StudentCourse" (
    "StudentID" integer NOT NULL,
    "CourseID" integer NOT NULL
);


ALTER TABLE public."StudentCourse" OWNER TO postgres;

--
-- TOC entry 220 (class 1259 OID 16580)
-- Name: Student_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public."Student" ALTER COLUMN "Id" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Student_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 219 (class 1259 OID 16577)
-- Name: Task; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Task" (
    "TaskName" character varying(255),
    "StudentID" integer NOT NULL,
    "CourseID" integer NOT NULL,
    "Deadline" timestamp without time zone
);


ALTER TABLE public."Task" OWNER TO postgres;

--
-- TOC entry 3345 (class 0 OID 16536)
-- Dependencies: 214
-- Data for Name: Admin; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Admin" ("Id", "Name", "Username", "NIP", "Jabatan", "Password") OVERRIDING SYSTEM VALUE VALUES (1, '123', '123', 123, '123', '123');


--
-- TOC entry 3348 (class 0 OID 16551)
-- Dependencies: 217
-- Data for Name: Course; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (2, 'UNU211101', 'Bahasa Indonesia dan Penulisan Ilmiah (A)', '""', 'Dr.Eng. Ir. Sunu Wibirama, S.T., M.Eng., IPM.', 'Senin', '07:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (3, 'TKU211122', 'Fisika Fluida, Kalor dan Gelombang (C)', '""', 'Ahmad Ataka Awwalur Rizqi , S.T., Ph.D', 'Senin', '07:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (4, 'TKU211121', 'Fisika Mekanika Klasik (C)', '""', 'Naufal Hilmi Fauzan, S.Si., M.T.', 'Senin', '07:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (6, 'TKU212241', 'Medan Elektromagnetik (A)', '""', 'Iswandi, S.T., M.Eng.', 'Senin', '07:00:00', 'TE2');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (7, 'TKU212101', 'Metode Numeris (A)', '""', 'Roni Irnawan, S.T., M.Sc., Ph.D.', 'Senin', '07:00:00', 'TE5');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (8, 'TIF215131', 'Pemrosesan Bahasa Alami (A)', '""', 'Syukron Abu Ishaq Alfarozi, S.T., Ph.D.', 'Senin', '07:00:00', 'E8');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (9, 'TKE215211', 'Pengolahan Statistis Isyarat (A)', '""', 'Dr. Indah Soesanti, S.T., M.T.', 'Senin', '07:00:00', 'RS');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (10, 'TKE215105', 'Teknik Proteksi (A)', '""', 'Ir. Bambang Sugiyantoro, M.T.', 'Senin', '07:00:00', 'E7');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (11, 'TIF212144', 'Arsitektur Komputer (A)', '""', 'Ir. Addin Suwastono, S.T., M.Eng., IPM.', 'Senin', '09:30:00', 'TE2');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (12, 'UNU211101', 'Bahasa Indonesia dan Penulisan Ilmiah (B)', '""', 'Drs. Rudi Ekasiswanto, M.Hum.', 'Senin', '09:30:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (13, 'TKE215101', 'Pembangkitan Tenaga Listrik (A)', '""', 'Ir. Tiyono, M.T.', 'Senin', '09:30:00', 'RS');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (14, 'TKE212203', 'Pengukuran dan Instrumentasi (A)', '""', 'Ir. Oyas Wahyunggoro, M.T., Ph.D.', 'Senin', '09:30:00', 'E7');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (15, 'TIF215122', 'Peretasan Beretika (A)', '""', 'Widyawan, S.T., M.Sc., Ph.D.', 'Senin', '09:30:00', 'TE3');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (16, 'TKU211211', 'Probabilitas dan Variabel Acak (A)', '""', 'Dr. Dyonisius Dony Ariananda, S.T., M.Sc.', 'Senin', '09:30:00', 'TE5');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (17, 'TKE215121', 'Sistem Tertanam dan Internet of Things (IoT) (A)', '""', 'Enas Dhuhri Kusuma, S.T., M.Eng.', 'Senin', '09:30:00', 'E8');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (18, 'TKU213101', 'Teknik Optimisasi (A)', '""', 'Ahmad Nasikun, S.T., M.Sc.', 'Senin', '09:30:00', 'E5');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (19, 'TKE213203', 'Analisis Sistem Tenaga (A)', '""', 'Ir. Lesnanto Multa Putranto, S.T., M.Eng., Ph.D., IPM.', 'Senin', '13:00:00', 'TE3');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (20, 'TKU211121', 'Fisika Mekanika Klasik (sebelum UTS) (A)', '""', 'Ir. Eka Firmansyah, S.T., M.Eng., Ph.D., IPM.', 'Senin', '13:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (21, 'TKU211122', 'Fisika Fluida, Kalor dan Gelombang (setelah UTS) (A)', '""', 'Ahmad Ataka Awwalur Rizqi , S.T., Ph.D', 'Senin', '13:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (22, 'TIF215121', 'Forensik Digital (A)', '""', 'Dani Adhipta, S.Si., M.T.', 'Senin', '13:00:00', 'RS');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (23, 'TKU212141', 'Isyarat dan Sistem (A)', '""', 'Dr. Dyonisius Dony Ariananda, S.T., M.Sc.', 'Senin', '13:00:00', 'TE5');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (24, 'TKU211101', 'Kalkulus Variabel Tunggal (sebelum UTS) (B)', '""', 'Fikri Waskito, S.T., M.Eng.', 'Senin', '13:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (25, 'TKU211103', 'Kalkulus Variabel Jamak (setelah UTS) (B)', '""', 'nan', 'Senin', '13:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (26, 'TKE215206', 'Kompatibilitas Elektromagnetik (A)', '""', 'Harry Prabowo, S.T., M.T.', 'Senin', '13:00:00', 'TE2');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (27, 'TKB214172', 'Manajemen Informasi Biomedis (A)', '""', 'Dr.Eng. Silmi Fauziati, S.T., M.T.', 'Senin', '13:00:00', 'E7');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (28, 'TKU211102', 'Matematika Diskrit (C)', '""', 'Dr. Sri Suning Kusumawardani, S.T., M.T.', 'Senin', '13:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (29, 'TKE215108', 'Perancangan Sistem Digital (A)', '""', 'Ir. Agus Bejo, S.T., M.Eng., D.Eng., IPM.', 'Senin', '13:00:00', 'E8');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (30, 'TKU211231', 'Algoritme dan Struktur Data (A)', '""', 'Dr. Indriana Hidayah, S.T., M.T.', 'Senin', '15:30:00', 'E3');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (31, 'TKU212243', 'Teknik Kendali (A)', '""', 'Dzuhri Radityo Utomo, S.T, M.E., Ph.D', 'Senin', '15:30:00', 'M21');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (32, 'TIF212242', 'Teknologi Basis Data (A)', '""', 'Warsun Najib, S.T., M.Sc.', 'Senin', '15:30:00', 'M23');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (33, 'UNU215101', 'Manajemen Industri (A)', '""', 'Ir. Subagyo, Ph.D.', 'Selasa', '07:00:00', 'RS');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (34, 'TKB213103', 'Teknik Biomekanika (A)', '""', 'Dr. Eng. Herianto, ST., M.Eng.', 'Selasa', '09:30:00', 'E7');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (35, 'TKB213275', 'Komputasi Genomik (A)', '""', 'Dosen Dummy,', 'Selasa', '13:00:00', 'RS');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (36, 'TKB211101', 'Kimia Dasar (A)', '""', 'Dr. Deni Pranowo, S.Si., M.Si.', 'Selasa', '15:30:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (37, 'TKB213102', 'Anatomi dan Fisiologi (A)', '""', 'Dosen Dummy,', 'Rabu', '07:00:00', 'RS');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (38, 'TKB214173', 'Biosibernetika (A)', '""', 'Dr.Eng. Igi Ardiyanto, S.T., M.Eng.', 'Rabu', '07:00:00', 'E8');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (39, 'TKE215203', 'Dinamika dan Stabilitas Sistem Tenaga Listrik (A)', '""', 'Prof. Dr. Ir. Sasongko Pramono H, DEA.', 'Rabu', '07:00:00', 'TE2');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (40, 'TKU211121', 'Fisika Mekanika Klasik (sebelum UTS) (B)', '""', 'Ahmad Ataka Awwalur Rizqi , S.T., Ph.D', 'Rabu', '07:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (41, 'TKU211122', 'Fisika Fluida, Kalor dan Gelombang (setelah UTS) (B)', '""', 'Ahmad Ataka Awwalur Rizqi , S.T., Ph.D', 'Rabu', '07:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (42, 'TKU211101', 'Kalkulus Variabel Tunggal (sebelum UTS) (A)', '""', 'Fikri Waskito, S.T., M.Eng.', 'Rabu', '07:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (43, 'TKU211103', 'Kalkulus Variabel Jamak (setelah UTS) (A)', '""', 'nan', 'Rabu', '07:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (44, 'TKU212101', 'Metode Numeris (B)', '""', 'Roni Irnawan, S.T., M.Sc., Ph.D.', 'Rabu', '07:00:00', 'TE3');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (45, 'TIF215111', 'Pengembangan Aplikasi Permainan (A)', '""', 'Dr. Ir. Ridi Ferdiana, S.T., M.T., IPM.', 'Rabu', '07:00:00', 'E7');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (46, 'TIF213144', 'Rekayasa Perangkat Lunak (A)', '""', 'Adhistya Erna Permanasari, S.T., M.T., Ph.D.', 'Rabu', '07:00:00', 'E6');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (47, 'TKE212201', 'Teknik Pengolahan Isyarat Digital (A)', '""', 'Enas Dhuhri Kusuma, S.T., M.Eng.', 'Rabu', '07:00:00', 'E5');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (48, 'TKE213104', 'Teknik Tenaga Listrik (A)', '""', 'Dr. Ir. M. Isnaeni Bambang Setyonegoro, M.T.', 'Rabu', '07:00:00', 'TE5');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (49, 'TKU211104', 'Teori Vektor dan Matriks (C)', '""', 'Dr.-Ing. Yohan Fajar Sidik, S.T., M.Eng.', 'Rabu', '07:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (50, 'TIF213148', 'Interaksi Manusia dan Komputer (A)', '""', 'Ir. P. Insap Santosa, M.Sc., Ph.D., IPU.', 'Rabu', '09:30:00', 'TE5');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (51, 'TKU211101', 'Kalkulus Variabel Tunggal (sebelum UTS) (C)', '""', 'Dr.Eng. Ir. F. Danang Wijaya, S.T., M.T., IPM.', 'Rabu', '09:30:00', 'E6');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (52, 'TKU211103', 'Kalkulus Variabel Jamak (setelah UTS) (C)', '""', 'nan', 'Rabu', '09:30:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (53, 'UNU214102', 'Kewirausahaan Teknologi (A)', '""', 'Ir. Lukito Edi Nugroho, M.Sc., Ph.D.', 'Rabu', '09:30:00', 'RS');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (54, 'TKE215207', 'Manajemen Energi (A)', '""', 'Ir. Tumiran, M. Eng., Ph. D.', 'Rabu', '09:30:00', 'TE2');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (55, 'TKU211131', 'Pemrograman Dasar (A)', '""', 'Dr. Indriana Hidayah, S.T., M.T.', 'Rabu', '09:30:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (56, 'TIF215112', 'Pengembangan Aplikasi Piranti Bergerak (A)', '""', 'Azkario Rizky Pratama, S.T., M.Eng., Ph.D.', 'Rabu', '09:30:00', 'TE3');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (57, 'TKB214171', 'Robotika Biomedis (A)', '""', 'Dr.Eng. Igi Ardiyanto, S.T., M.Eng.', 'Rabu', '09:30:00', 'E7');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (58, 'TKE215116', 'Sistem Kendali Lanjut (A)', '""', 'Ir. Oyas Wahyunggoro, M.T., Ph.D.', 'Rabu', '09:30:00', 'E8');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (59, 'TKU212111', 'Statistika (A)', '""', 'Ir. Sigit Basuki Wibowo, S.T., M.Eng., Ph.D., IPM.', 'Rabu', '09:30:00', 'E5');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (60, 'TKU211104', 'Teori Vektor dan Matriks (B)', '""', 'Husni Rois Ali, S.T., M.Eng., Ph.D.', 'Rabu', '09:30:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (61, 'TKE213101', 'Elektronika Analog (A)', '""', 'Ir. Prapto Nugroho, S.T., M.Eng., D.Eng., IPM.', 'Rabu', '13:00:00', 'TE5');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (5, 'TKU213141', 'Komunikasi Data Komputer', '""', 'Ir. Sujoko Sumaryono, M.T.', 'Senin', '07:00:00', 'E6');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (62, 'TKU211121', 'Fisika Mekanika Klasik (sebelum UTS) (C)', '""', 'Naufal Hilmi Fauzan, S.Si., M.T.', 'Rabu', '13:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (63, 'TKU211122', 'Fisika Fluida, Kalor dan Gelombang (setelah UTS) (C)', '""', 'Ahmad Ataka Awwalur Rizqi , S.T., Ph.D', 'Rabu', '13:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (64, 'TKU212141', 'Isyarat dan Sistem (B)', '""', 'Dr. Dyonisius Dony Ariananda, S.T., M.Sc.', 'Rabu', '13:00:00', 'E6');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (65, 'TIF212246', 'Jaringan Komputer (A)', '""', 'Ir. Sujoko Sumaryono, M.T.', 'Rabu', '13:00:00', 'E7');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (66, 'TKU211102', 'Matematika Diskrit (A)', '""', 'Dr. Sri Suning Kusumawardani, S.T., M.T.', 'Rabu', '13:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (67, 'TKU211131', 'Pemrograman Dasar (C)', '""', 'Bimo Sunarfri Hantono, S.T., M.Eng.', 'Rabu', '13:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (68, 'TIF215213', 'Pengalaman Pengguna (A)', '""', 'Dr.Eng. Ir. Sunu Wibirama, S.T., M.Eng., IPM.', 'Rabu', '13:00:00', 'TE3');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (69, 'TKE215103', 'Perlengkapan Sistem Tenaga (A)', '""', 'Ir. Tiyono, M.T.', 'Rabu', '13:00:00', 'RS');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (70, 'TKE215213', 'Sistem Komunikasi Nirkabel (A)', '""', 'Ir. Wahyu Dewanto, M.T.', 'Rabu', '13:00:00', 'E8');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (71, 'TKE215119', 'Teknik Antarmuka dan Periferal (A)', '""', 'Dani Adhipta, S.Si., M.T.', 'Rabu', '13:00:00', 'TE2');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (72, 'TIF212244', 'Kecerdasan Buatan (A)', '""', 'Syukron Abu Ishaq Alfarozi, S.T., Ph.D.', 'Rabu', '15:30:00', 'E3');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (73, 'TKB213101', 'Elektronika Biomedis (A)', '""', 'Ir. Prapto Nugroho, S.T., M.Eng., D.Eng., IPM.', 'Kamis', '07:00:00', 'M23');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (74, 'TKE215111', 'Antena dan Perambatan Gelombang (A)', '""', 'Iswandi, S.T., M.Eng.', 'Kamis', '07:00:00', 'E8');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (75, 'TKE215205', 'Keandalan Sistem Tenaga Listrik (A)', '""', 'Ir. Tumiran, M. Eng., Ph. D.', 'Kamis', '07:00:00', 'RS');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (76, 'TKB213276', 'Kecerdasan Buatan Biomedis (A)', '""', 'Dr.Eng. Igi Ardiyanto, S.T., M.Eng.', 'Kamis', '07:00:00', 'E7');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (77, 'TKE213103', 'Mesin Listrik 1 (A)', '""', 'Dr. Ir. M. Isnaeni Bambang Setyonegoro, M.T.', 'Kamis', '07:00:00', 'TE5');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (78, 'TIF212143', 'Pemrograman Berorientasi Obyek (A)', '""', 'Ahmad Nasikun, S.T., M.Sc.', 'Kamis', '07:00:00', 'TE2');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (79, 'TKU211131', 'Pemrograman Dasar (B)', '""', 'Dr.Eng. Silmi Fauziati, S.T., M.T.', 'Kamis', '07:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (80, 'TKU212142', 'Teknik Digital (A)', '""', 'Dr. Ir. Risanuri Hidayat, M.Sc., IPM.', 'Kamis', '07:00:00', 'E6');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (81, 'TKE215221', 'Teknik Neurofuzi (A)', '""', 'Ir. Oyas Wahyunggoro, M.T., Ph.D.', 'Kamis', '07:00:00', 'E5');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (82, 'TIF215215', 'TIK dan Masyarakat (A)', '""', 'Muhammad Nur Rizal, S.T., M. Eng., Ph.D.', 'Kamis', '07:00:00', 'TE3');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (83, 'TKU211122', 'Fisika Fluida, Kalor dan Gelombang (A)', '""', 'Ahmad Ataka Awwalur Rizqi , S.T., Ph.D', 'Kamis', '09:30:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (84, 'TKU211121', 'Fisika Mekanika Klasik (A)', '""', 'Ir. Eka Firmansyah, S.T., M.Eng., Ph.D., IPM.', 'Kamis', '09:30:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (85, 'TIF213147', 'Komputasi Awan (A)', '""', 'Ir. Sigit Basuki Wibowo, S.T., M.Eng., Ph.D., IPM.', 'Kamis', '09:30:00', 'E5');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (86, 'TIF212142', 'Komunikasi Data dan Komputer (A)', '""', 'Ir. Sujoko Sumaryono, M.T.', 'Kamis', '09:30:00', 'TE3');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (87, 'TKU211131', 'Pemrograman Dasar (E)', '""', 'Bimo Sunarfri Hantono, S.T., M.Eng.', 'Kamis', '09:30:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (88, 'TKE213102', 'Perancangan Sistem Kendali Modern (A)', '""', 'Dr.Eng. Ir. Adha Imam Cahyadi, S.T., M.Eng., IPM.', 'Kamis', '09:30:00', 'TE5');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (89, 'TKB213105', 'Sensor dan Transduser (A)', '""', 'Ir. Noor Akhmad Setiawan, S.T., M.T., Ph.D., IPM.', 'Kamis', '09:30:00', 'E7');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (90, 'TKB213273', 'Sistem Diagnosis Berbasis Pendukung Keputusan (A)', '""', 'Ir. Hanung Adi Nugroho, S.T., M.E., Ph.D., IPM.', 'Kamis', '09:30:00', 'RS');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (91, 'TKE215201', 'Topik Khusus Teknik Elektro (A)', '""', 'Ir. Lesnanto Multa Putranto, S.T., M.Eng., Ph.D., IPM.', 'Kamis', '09:30:00', 'TE2');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (92, 'TIF215211', 'Topik Khusus Teknologi Informasi (A)', '""', 'Widyawan, S.T., M.Sc., Ph.D.', 'Kamis', '09:30:00', 'TE2');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (93, 'TKB214175', 'Topik Khusus Teknik Biomedis 1 (A)', '""', 'Prof Johan Debayle,', 'Kamis', '09:30:00', 'TE2');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (94, 'TKE215102', 'Transmisi dan Gardu Induk (A)', '""', 'Ir. Bambang Sugiyantoro, M.T.', 'Kamis', '09:30:00', 'E8');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (95, 'TIF215132', 'Big Data dan Analitik (A)', '""', 'Dr.Eng. Silmi Fauziati, S.T., M.T.', 'Kamis', '13:00:00', 'RS');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (96, 'TKU211122', 'Fisika Fluida, Kalor dan Gelombang (B)', '""', 'Ahmad Ataka Awwalur Rizqi , S.T., Ph.D', 'Kamis', '13:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (97, 'TKU211121', 'Fisika Mekanika Klasik (B)', '""', 'Ahmad Ataka Awwalur Rizqi , S.T., Ph.D', 'Kamis', '13:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (98, 'TKB212203', 'Pengukuran dan Instrumentasi Biomedis (A)', '""', 'Ir. Prapto Nugroho, S.T., M.Eng., D.Eng., IPM.', 'Kamis', '13:00:00', 'TE3');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (99, 'TIF213145', 'Rekayasa Data (A)', '""', 'Syukron Abu Ishaq Alfarozi, S.T., Ph.D.', 'Kamis', '13:00:00', 'TE5');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (100, 'TKU212111', 'Statistika (B)', '""', 'Ir. Sigit Basuki Wibowo, S.T., M.Eng., Ph.D., IPM.', 'Kamis', '13:00:00', 'E5');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (101, 'TKB212202', 'Teknik Pengolahan Isyarat Biomedis (A)', '""', 'Dr. Indah Soesanti, S.T., M.T.', 'Kamis', '13:00:00', 'E8');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (102, 'TIF212245', 'Teknik Visualisasi Grafis (A)', '""', 'Dr. Ir. Rudy Hartanto, M.T., IPM.', 'Kamis', '13:00:00', 'M21');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (103, 'TKU211202', 'Aljabar Linear (A)', '""', 'Dr.-Ing. Yohan Fajar Sidik, S.T., M.Eng.', 'Kamis', '15:30:00', 'E3');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (104, 'TKU211201', 'Analisis Variabel Kompleks (A)', '""', 'Naufal Hilmi Fauzan, S.Si., M.T.', 'Kamis', '15:30:00', 'M21');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (105, 'TIF215212', 'Transformasi Digital (A)', '""', 'Ir. Lukito Edi Nugroho, M.Sc., Ph.D.', 'Kamis', '15:30:00', 'ol');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (106, 'TKU212143', 'Analisis Untai Elektrik DC (A)', '""', 'Ir. Sigit Basuki Wibowo, S.T., M.Eng., Ph.D., IPM.', 'Jumat', '07:00:00', 'E6');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (107, 'TKE215106', 'Desain Listrik Industri (A)', '""', 'Ir. Tiyono, M.T.', 'Jumat', '07:00:00', 'E7');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (108, 'TKU212242', 'Elektronika Dasar (A)', '""', 'Ir. Prapto Nugroho, S.T., M.Eng., D.Eng., IPM.', 'Jumat', '07:00:00', 'TE2');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (109, 'TKE213202', 'Mesin Listrik 2 (A)', '""', 'Ir. Bambang Sugiyantoro, M.T.', 'Jumat', '07:00:00', 'RS');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (110, 'TKU211131', 'Pemrograman Dasar (D)', '""', 'Dr.Eng. Silmi Fauziati, S.T., M.T.', 'Jumat', '07:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (111, 'TKE215225', 'Programmable Logic Controller (PLC) dan Praktikum (A)', '""', 'Ir. Sujoko Sumaryono, M.T.', 'Jumat', '07:00:00', 'E8');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (112, 'TIF212243', 'Sistem Berbasis Mikroprosesor (A)', '""', 'Ir. Addin Suwastono, S.T., M.Eng., IPM.', 'Jumat', '07:00:00', 'E5');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (113, 'TKE213201', 'Sistem Komunikasi (A)', '""', 'Dr. Ir. Risanuri Hidayat, M.Sc., IPM.', 'Jumat', '07:00:00', 'TE3');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (114, 'TIF213141', 'Sistem Operasi (A)', '""', 'Dani Adhipta, S.Si., M.T.', 'Jumat', '07:00:00', 'TE5');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (115, 'TKU211102', 'Matematika Diskrit (B)', '""', 'Syukron Abu Ishaq Alfarozi, S.T., Ph.D.', 'Jumat', '13:00:00', 'SGLC');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (116, 'TIF213146', 'Pengembangan Aplikasi Web (A)', '""', 'Bimo Sunarfri Hantono, S.T., M.Eng.', 'Jumat', '13:00:00', 'E5');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (117, 'TKE215219', 'Robot Bergerak (A)', '""', 'Dr.Eng. Igi Ardiyanto, S.T., M.Eng.', 'Jumat', '13:00:00', 'E7');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (118, 'TKU212244', 'Sistem Mikroprosesor (A)', '""', 'Ir. Addin Suwastono, S.T., M.Eng., IPM.', 'Jumat', '13:00:00', 'TE3');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (119, 'TKU213101', 'Teknik Optimisasi (B)', '""', 'Roni Irnawan, S.T., M.Sc., Ph.D.', 'Jumat', '13:00:00', 'TE2');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (120, 'TIF212247', 'Teknik Pemodelan dan Simulasi (A)', '""', 'Dr. Indriana Hidayah, S.T., M.T.', 'Jumat', '13:00:00', 'RS');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (121, 'TKE215104', 'Teknik Tegangan Tinggi (A)', '""', 'Naufal Hilmi Fauzan, S.Si., M.T.', 'Jumat', '13:00:00', 'E8');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (122, 'TKU212102', 'Telekomunikasi Dasar (A)', '""', 'Ir. Wahyu Dewanto, M.T.', 'Jumat', '13:00:00', 'TE5');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (123, 'TKU211104', 'Teori Vektor dan Matriks (A)', '""', 'Dr.-Ing. Yohan Fajar Sidik, S.T., M.Eng.', 'Jumat', '13:00:00', 'E6');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (124, 'TKU211221', 'Fisika Listrik dan Magnet (A)', '""', 'Dr.-Ing. Yohan Fajar Sidik, S.T., M.Eng.', 'Jumat', '15:30:00', 'E3');
INSERT INTO public."Course" ("Id", "Code", "Name", "Description", "Lecturer", "Day", "StartTime", "Room") OVERRIDING SYSTEM VALUE VALUES (125, 'TKU211203', 'Persamaan Diferensial (A)', '""', 'Naufal Hilmi Fauzan, S.Si., M.T.', 'Jumat', '15:30:00', 'M21');


--
-- TOC entry 3346 (class 0 OID 16543)
-- Dependencies: 215
-- Data for Name: Student; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Student" ("Id", "Name", "Username", "NIU", "Prodi", "Password") OVERRIDING SYSTEM VALUE VALUES (3, 'KARUNIA PERJUANGAN MUSTADL''AFIN', 'akujuang', 456368, 'S1 TEKNOLOGI INFORMASI', '123123');
INSERT INTO public."Student" ("Id", "Name", "Username", "NIU", "Prodi", "Password") OVERRIDING SYSTEM VALUE VALUES (7, 'SATRIA QOMARUL AKBAR', 'akbar', 456300, 'S1 TEKNIK MESIN', 'akbar');
INSERT INTO public."Student" ("Id", "Name", "Username", "NIU", "Prodi", "Password") OVERRIDING SYSTEM VALUE VALUES (8, 'ELSA MIRANDA KRISTIAN', 'elsa', 456240, 'S1 TEKNIK KIMIA', 'elsa');


--
-- TOC entry 3349 (class 0 OID 16564)
-- Dependencies: 218
-- Data for Name: StudentCourse; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."StudentCourse" ("StudentID", "CourseID") VALUES (3, 78);
INSERT INTO public."StudentCourse" ("StudentID", "CourseID") VALUES (3, 79);
INSERT INTO public."StudentCourse" ("StudentID", "CourseID") VALUES (7, 6);
INSERT INTO public."StudentCourse" ("StudentID", "CourseID") VALUES (8, 5);
INSERT INTO public."StudentCourse" ("StudentID", "CourseID") VALUES (8, 8);
INSERT INTO public."StudentCourse" ("StudentID", "CourseID") VALUES (8, 21);
INSERT INTO public."StudentCourse" ("StudentID", "CourseID") VALUES (7, 5);
INSERT INTO public."StudentCourse" ("StudentID", "CourseID") VALUES (7, 10);


--
-- TOC entry 3350 (class 0 OID 16577)
-- Dependencies: 219
-- Data for Name: Task; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3359 (class 0 OID 0)
-- Dependencies: 221
-- Name: Admin_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Admin_Id_seq"', 2, true);


--
-- TOC entry 3360 (class 0 OID 0)
-- Dependencies: 216
-- Name: Course_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Course_Id_seq"', 129, true);


--
-- TOC entry 3361 (class 0 OID 0)
-- Dependencies: 220
-- Name: Student_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Student_Id_seq"', 8, true);


--
-- TOC entry 3192 (class 2606 OID 16542)
-- Name: Admin Admin_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Admin"
    ADD CONSTRAINT "Admin_pkey" PRIMARY KEY ("Id");


--
-- TOC entry 3200 (class 2606 OID 16557)
-- Name: Course Course_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Course"
    ADD CONSTRAINT "Course_pkey" PRIMARY KEY ("Id");


--
-- TOC entry 3196 (class 2606 OID 16549)
-- Name: Student Student_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Student"
    ADD CONSTRAINT "Student_pkey" PRIMARY KEY ("Id");


--
-- TOC entry 3194 (class 2606 OID 16588)
-- Name: Admin UsernameUniqueAdm; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Admin"
    ADD CONSTRAINT "UsernameUniqueAdm" UNIQUE ("Username");


--
-- TOC entry 3198 (class 2606 OID 16586)
-- Name: Student UsernameUniqueStud; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Student"
    ADD CONSTRAINT "UsernameUniqueStud" UNIQUE ("Username");


--
-- TOC entry 3201 (class 2606 OID 16572)
-- Name: StudentCourse FK_CourseID; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."StudentCourse"
    ADD CONSTRAINT "FK_CourseID" FOREIGN KEY ("CourseID") REFERENCES public."Course"("Id");


--
-- TOC entry 3202 (class 2606 OID 16567)
-- Name: StudentCourse FK_StudID; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."StudentCourse"
    ADD CONSTRAINT "FK_StudID" FOREIGN KEY ("StudentID") REFERENCES public."Student"("Id");


-- Completed on 2022-11-21 07:47:17

--
-- PostgreSQL database dump complete
--

