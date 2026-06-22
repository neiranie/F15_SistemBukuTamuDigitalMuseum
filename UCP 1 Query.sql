SELECT name FROM sys.procedures WHERE name LIKE '%BukuTamu%'

USE DBBukuTamuMuseum;
GO

CREATE PROCEDURE sp_SearchBukuTamu
    @Keyword NVARCHAR(100)
AS
BEGIN
    SELECT idTamu, namaLengkap, asalDaerah, keperluan, tanggal
    FROM BukuTamu
    WHERE namaLengkap LIKE '%' + @Keyword + '%'
       OR asalDaerah  LIKE '%' + @Keyword + '%'
       OR keperluan   LIKE '%' + @Keyword + '%'
    ORDER BY tanggal DESC
END
GO



USE DBBukuTamuMuseum;
SELECT name, type_desc, create_date, modify_date 
FROM sys.procedures 
WHERE name LIKE '%BukuTamu%';

SELECT name, type_desc 
FROM sys.views 
WHERE name LIKE '%BukuTamu%';


/* ============================================================
   1. DATABASE & TABEL
   ============================================================ */

CREATE DATABASE DBBukuTamuMuseum;
GO

USE DBBukuTamuMuseum;
GO

CREATE TABLE Petugas (
    idPetugas INT IDENTITY(1,1) PRIMARY KEY,
    nama VARCHAR(100) NOT NULL,
    username VARCHAR(50) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL
);
GO

CREATE TABLE BukuTamu (
    idTamu INT IDENTITY(1,1) PRIMARY KEY,
    namaLengkap VARCHAR(100) NOT NULL,
    asalDaerah VARCHAR(100) NOT NULL,
    keperluan VARCHAR(200) NOT NULL,
    tanggal DATETIME DEFAULT GETDATE()
);
GO

INSERT INTO Petugas (nama, username, password) VALUES
('Admin', 'admin', 'admin123');
GO

INSERT INTO BukuTamu (namaLengkap, asalDaerah, keperluan, tanggal) VALUES
('Neira', 'Yogyakarta', 'Kunjungan Edukasi', '2025-01-10'),
('Fira', 'Yogyakarta', 'Penelitian', '2025-01-11'),
('Miftah', 'Yogyakarta', 'Wisata', '2025-01-12');
GO


/* ============================================================
   2. VIEW vw_BukuTamu
   ============================================================ */
USE DBBukuTamuMuseum;
GO

IF OBJECT_ID('vw_BukuTamu', 'V') IS NOT NULL
    DROP VIEW vw_BukuTamu;
GO

CREATE VIEW vw_BukuTamu AS
SELECT 
    idTamu,
    namaLengkap,
    asalDaerah,
    keperluan,
    CONVERT(VARCHAR, tanggal, 103) AS tanggal
FROM BukuTamu;
GO


/* ============================================================
   3. STORED PROCEDURE CRUD UTAMA
   ============================================================ */

-- SP INSERT
IF OBJECT_ID('sp_InsertBukuTamu', 'P') IS NOT NULL
    DROP PROCEDURE sp_InsertBukuTamu;
GO

CREATE PROCEDURE sp_InsertBukuTamu
    @Nama NVARCHAR(100),
    @AsalDaerah NVARCHAR(100),
    @Tujuan NVARCHAR(200),
    @Tanggal DATE
AS
BEGIN
    IF EXISTS (
        SELECT 1 FROM BukuTamu 
        WHERE namaLengkap = @Nama 
        AND asalDaerah = @AsalDaerah 
        AND keperluan = @Tujuan 
        AND CAST(tanggal AS DATE) = @Tanggal
    )
    BEGIN
        RAISERROR('Data sudah ada, tidak boleh duplikasi!', 16, 1)
        RETURN
    END
    INSERT INTO BukuTamu (namaLengkap, asalDaerah, keperluan, tanggal)
    VALUES (@Nama, @AsalDaerah, @Tujuan, @Tanggal)
END
GO

-- SP UPDATE
IF OBJECT_ID('sp_UpdateBukuTamu', 'P') IS NOT NULL
    DROP PROCEDURE sp_UpdateBukuTamu;
GO

CREATE PROCEDURE sp_UpdateBukuTamu
    @IdTamu INT,
    @Nama NVARCHAR(100),
    @AsalDaerah NVARCHAR(100),
    @Tujuan NVARCHAR(200),
    @Tanggal DATE
AS
BEGIN
    IF EXISTS (
        SELECT 1 FROM BukuTamu 
        WHERE idTamu = @IdTamu
        AND namaLengkap = @Nama 
        AND asalDaerah = @AsalDaerah 
        AND keperluan = @Tujuan 
        AND CAST(tanggal AS DATE) = @Tanggal
    )
    BEGIN
        RAISERROR('Tidak ada perubahan data!', 16, 1)
        RETURN
    END
    IF EXISTS (
        SELECT 1 FROM BukuTamu 
        WHERE namaLengkap = @Nama 
        AND asalDaerah = @AsalDaerah 
        AND keperluan = @Tujuan 
        AND CAST(tanggal AS DATE) = @Tanggal
        AND idTamu != @IdTamu
    )
    BEGIN
        RAISERROR('Data sama sudah ada, perubahan harus berbeda!', 16, 1)
        RETURN
    END
    UPDATE BukuTamu
    SET namaLengkap = @Nama,
        asalDaerah = @AsalDaerah,
        keperluan = @Tujuan,
        tanggal = @Tanggal
    WHERE idTamu = @IdTamu
END
GO

-- SP DELETE
IF OBJECT_ID('sp_DeleteBukuTamu', 'P') IS NOT NULL
    DROP PROCEDURE sp_DeleteBukuTamu;
GO

CREATE PROCEDURE sp_DeleteBukuTamu
    @IdTamu INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM BukuTamu WHERE idTamu = @IdTamu)
    BEGIN
        RAISERROR('Data tidak ditemukan!', 16, 1)
        RETURN
    END
    DELETE FROM BukuTamu WHERE idTamu = @IdTamu
END
GO

-- SP SEARCH
IF OBJECT_ID('sp_SearchBukuTamu', 'P') IS NOT NULL
    DROP PROCEDURE sp_SearchBukuTamu;
GO

CREATE PROCEDURE sp_SearchBukuTamu
    @Keyword NVARCHAR(100)
AS
BEGIN
    SELECT idTamu, namaLengkap, asalDaerah, keperluan, tanggal
    FROM BukuTamu
    WHERE namaLengkap LIKE '%' + @Keyword + '%'
       OR asalDaerah LIKE '%' + @Keyword + '%'
       OR keperluan LIKE '%' + @Keyword + '%'
    ORDER BY tanggal DESC
END
GO


/* ============================================================
   4. STORED PROCEDURE TAMBAHAN
   (untuk Menampilkan Data, Total, dan Login yang aman)
   ============================================================ */

-- sp_GetAllBukuTamu : SELECT semua data (tombol "Menampilkan Data")
IF OBJECT_ID('sp_GetAllBukuTamu', 'P') IS NOT NULL
    DROP PROCEDURE sp_GetAllBukuTamu;
GO

CREATE PROCEDURE sp_GetAllBukuTamu
AS
BEGIN
    SELECT idTamu, namaLengkap, asalDaerah, keperluan, tanggal
    FROM BukuTamu
    ORDER BY idTamu DESC
END
GO

-- sp_CountBukuTamu : hitung total data (label Total di Form1)
IF OBJECT_ID('sp_CountBukuTamu', 'P') IS NOT NULL
    DROP PROCEDURE sp_CountBukuTamu;
GO

CREATE PROCEDURE sp_CountBukuTamu
AS
BEGIN
    SELECT COUNT(*) AS TotalTamu FROM BukuTamu
END
GO

IF OBJECT_ID('sp_GetPetugasByUsername', 'P') IS NOT NULL
    DROP PROCEDURE sp_GetPetugasByUsername;
GO

CREATE PROCEDURE sp_GetPetugasByUsername
    @Username NVARCHAR(50)
AS
BEGIN
    SELECT idPetugas, nama, username, password
    FROM Petugas
    WHERE username = @Username
END
GO


/* ============================================================
   5. TRIGGER & TABEL LOG AKTIVITAS (Audit Trail)
   ============================================================ */

IF OBJECT_ID('LogAktivitasTamu', 'U') IS NOT NULL
    DROP TABLE LogAktivitasTamu;
GO

CREATE TABLE LogAktivitasTamu (
    idLog INT IDENTITY(1,1) PRIMARY KEY,
    idTamu INT NOT NULL,
    aksi VARCHAR(10) NOT NULL,
    namaLengkapLama VARCHAR(100) NULL,
    namaLengkapBaru VARCHAR(100) NULL,
    asalDaerahLama VARCHAR(100) NULL,
    asalDaerahBaru VARCHAR(100) NULL,
    keperluanLama VARCHAR(200) NULL,
    keperluanBaru VARCHAR(200) NULL,
    waktuAksi DATETIME NOT NULL DEFAULT GETDATE(),
    olehUser VARCHAR(100) NOT NULL DEFAULT SUSER_SNAME()
);
GO

-- Trigger INSERT
IF OBJECT_ID('trg_BukuTamu_Insert', 'TR') IS NOT NULL
    DROP TRIGGER trg_BukuTamu_Insert;
GO

CREATE TRIGGER trg_BukuTamu_Insert
ON BukuTamu
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO LogAktivitasTamu
        (idTamu, aksi, namaLengkapBaru, asalDaerahBaru, keperluanBaru)
    SELECT
        idTamu, 'INSERT', namaLengkap, asalDaerah, keperluan
    FROM inserted;
END
GO

-- Trigger UPDATE
IF OBJECT_ID('trg_BukuTamu_Update', 'TR') IS NOT NULL
    DROP TRIGGER trg_BukuTamu_Update;
GO

CREATE TRIGGER trg_BukuTamu_Update
ON BukuTamu
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO LogAktivitasTamu
        (idTamu, aksi,
         namaLengkapLama, namaLengkapBaru,
         asalDaerahLama, asalDaerahBaru,
         keperluanLama, keperluanBaru)
    SELECT
        d.idTamu, 'UPDATE',
        d.namaLengkap, i.namaLengkap,
        d.asalDaerah, i.asalDaerah,
        d.keperluan, i.keperluan
    FROM deleted d
    INNER JOIN inserted i ON d.idTamu = i.idTamu;
END
GO

-- Trigger DELETE
IF OBJECT_ID('trg_BukuTamu_Delete', 'TR') IS NOT NULL
    DROP TRIGGER trg_BukuTamu_Delete;
GO

CREATE TRIGGER trg_BukuTamu_Delete
ON BukuTamu
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO LogAktivitasTamu
        (idTamu, aksi, namaLengkapLama, asalDaerahLama, keperluanLama)
    SELECT
        idTamu, 'DELETE', namaLengkap, asalDaerah, keperluan
    FROM deleted;
END
GO

-- SP untuk menampilkan log aktivitas
IF OBJECT_ID('sp_GetLogAktivitas', 'P') IS NOT NULL
    DROP PROCEDURE sp_GetLogAktivitas;
GO

CREATE PROCEDURE sp_GetLogAktivitas
AS
BEGIN
    SELECT TOP 200
        idLog, idTamu, aksi,
        ISNULL(namaLengkapBaru, namaLengkapLama) AS namaLengkap,
        namaLengkapLama, namaLengkapBaru,
        asalDaerahLama, asalDaerahBaru,
        keperluanLama, keperluanBaru,
        waktuAksi, olehUser
    FROM LogAktivitasTamu
    ORDER BY waktuAksi DESC
END
GO


/* ============================================================
   6. VIEW & SP UNTUK REPORT (Crystal Reports)
   ============================================================ */

IF OBJECT_ID('vw_LaporanKunjungan', 'V') IS NOT NULL
    DROP VIEW vw_LaporanKunjungan;
GO

CREATE VIEW vw_LaporanKunjungan AS
SELECT
    idTamu,
    namaLengkap,
    asalDaerah,
    keperluan,
    tanggal,
    DATENAME(MONTH, tanggal) AS NamaBulan,
    YEAR(tanggal) AS Tahun
FROM BukuTamu;
GO

IF OBJECT_ID('sp_GetLaporanKunjungan', 'P') IS NOT NULL
    DROP PROCEDURE sp_GetLaporanKunjungan;
GO

CREATE PROCEDURE sp_GetLaporanKunjungan
    @TanggalMulai DATE,
    @TanggalSelesai DATE
AS
BEGIN
    SET NOCOUNT ON;
    SELECT idTamu, namaLengkap, asalDaerah, keperluan, tanggal
    FROM BukuTamu
    WHERE CAST(tanggal AS DATE) BETWEEN @TanggalMulai AND @TanggalSelesai
    ORDER BY tanggal ASC
END
GO


PRINT '============================================================';
PRINT 'SELESAI! Semua tabel, view, SP, dan trigger berhasil dibuat:';
PRINT '- Tabel: Petugas, BukuTamu, LogAktivitasTamu';
PRINT '- View : vw_BukuTamu, vw_LaporanKunjungan';
PRINT '- SP   : sp_InsertBukuTamu, sp_UpdateBukuTamu, sp_DeleteBukuTamu,';
PRINT '         sp_SearchBukuTamu, sp_GetAllBukuTamu, sp_CountBukuTamu,';
PRINT '         sp_GetPetugasByUsername, sp_GetLogAktivitas,';
PRINT '         sp_GetLaporanKunjungan';
PRINT '- Trigger: trg_BukuTamu_Insert, trg_BukuTamu_Update, trg_BukuTamu_Delete';
PRINT '============================================================';
