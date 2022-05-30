CREATE TABLE PersonelGiris(
id tinyint identity (1,1),
KullanýcýAd varchar(10),
Sifre varchar (15),
)

INSERT INTO PersonelGiris(KullanýcýAd,Sifre)
VALUES ('admin', 'a8M427') 

CREATE TABLE HastaKayit(
id int identity (1,1),
HastaAd varchar(30),
HastaSoyad varchar(30),
TCKimlik varchar(11),
Tel varchar (11),
Adres varchar (200)
); 

INSERT INTO HastaKayit(HastaAd,HastaSoyad,Tel,TCKimlik,Adres) VALUES ('Ayþe','Bozdoðan','5326759144','12332112322','Acýbadem Mh. Erol Günaydýn Sok. No:2');

CREATE PROCEDURE sp_kayit (@HastaAd varchar(30), @HastaSoyad varchar(30),@TCKimlik varchar(11),@Tel varchar (11),@Adres varchar (200))
AS
BEGIN
	INSERT INTO HastaKayit(HastaAd, HastaSoyad, TCKimlik, Tel, Adres) VALUES (@HastaAd, @HastaSoyad, @TCKimlik, @Tel, @Adres);
END
GO

CREATE PROC sp_sil (@TCKimlik varchar(11))
AS
BEGIN
DELETE FROM HastaKayit WHERE @TCKimlik = TCKimlik;
END
GO

CREATE PROC sp_guncelle (@Id int, @HastaAd varchar(30), @HastaSoyad varchar(30),@TCKimlik varchar(11),@Tel varchar (11),@Adres varchar (200))
AS
BEGIN
UPDATE HastaKayit SET HastaAd = @HastaAd,  HastaSoyad = @HastaSoyad,  TCKimlik = @TCKimlik, Tel = @Tel, Adres = @Adres WHERE id = @Id
END
GO


CREATE PROC sp_arama (@HastaAd varchar(30))
AS
BEGIN
SELECT * FROM HastaKayit WHERE HastaAd LIKE '%'+@HastaAd+'%'
END
GO

CREATE PROC sp_aramatc (@TCKimlik varchar(11))
AS
BEGIN
SELECT * FROM HastaKayit WHERE TCKimlik LIKE @TCKimlik
END
GO

CREATE TABLE IlacEkle(
id int identity (1,1),
Barkod char(10) NOT NULL,
Ad varchar (50) NOT NULL,
Miktar tinyint NOT NULL,
Fiyat decimal (6,2) NOT NULL,
Firma varchar (50) NOT NULL
);

SELECT * FROM IlacEkle

CREATE PROCEDURE sp_ilackayit (@Barkod char(10), @Ad varchar (50),@Miktar tinyint,@Fiyat decimal (6,2),@Firma varchar (50))
AS
BEGIN
	INSERT INTO IlacEkle(Barkod, Ad, Miktar, Fiyat, Firma) VALUES (@Barkod, @Ad, @Miktar, @Fiyat, @Firma);
END
GO

CREATE PROC sp_ilacsil (@Barkod varchar(11))
AS
BEGIN
DELETE FROM IlacEkle WHERE @Barkod = Barkod;
END
GO

CREATE PROC sp_ilacguncelle (@Id int, @Barkod char(10), @Ad varchar (50),@Miktar tinyint,@Fiyat decimal (6,2),@Firma varchar (50))
AS
BEGIN
UPDATE IlacEkle SET Barkod = @Barkod,  Ad = @Ad,  Miktar = @Miktar, Fiyat = @Fiyat, Firma = @Firma WHERE id = @Id
END
GO

CREATE PROC sp_ilacarama (@Ad varchar (50))
AS
BEGIN
SELECT * FROM IlacEkle WHERE Ad LIKE '%'+@Ad+'%'
END
GO

CREATE TABLE Firmalar(
id tinyint identity(1,1),
FirmaAdlar varchar(50)
);

ALTER TABLE Firmalar
ADD CONSTRAINT U_Firmalar_FirmaAdlar
UNIQUE (FirmaAdlar);


ALTER TABLE IlacEkle
ADD CONSTRAINT FK_IlacEkle_Firma_Firmalar_FirmaAdlar
FOREIGN KEY (Firma)
REFERENCES Firmalar(FirmaAdlar);


ALTER TABLE Firmalar
ADD CONSTRAINT C_GirisTarih
DEFAULT '0000-00-00' FOR GirisTarihi 

CREATE PROCEDURE sp_firmakayit (@FirmaAdlar varchar(50), @GirisTarihi date)
AS
BEGIN
	INSERT INTO Firmalar(FirmaAdlar,GirisTarihi) VALUES (@FirmaAdlar, @GirisTarihi);
END
GO

CREATE PROC sp_firmasil (@FirmaAdlar varchar(50))
AS
BEGIN
DELETE FROM Firmalar WHERE @FirmaAdlar = FirmaAdlar;
END
GO

CREATE PROC sp_firmaguncelle (@fId int, @FirmaAdlar varchar(50), @GirisTarihi date)
AS
BEGIN
UPDATE Firmalar SET FirmaAdlar=@FirmaAdlar, GirisTarihi = @GirisTarihi WHERE id = @fId
END
GO

CREATE PROC sp_firmaarama (@FirmaAdlar varchar (50))
AS
BEGIN
SELECT * FROM Firmalar WHERE FirmaAdlar LIKE '%'+@FirmaAdlar+'%'
END
GO

CREATE TABLE ReceteSatis(
id int identity(1,1) NOT NULL,
HastaTc char (11) NOT NULL,
IlacAdi varchar (50) NOT NULL,
Tarih date NOT NULL DEFAULT getdate(),
Adet tinyint NOT NULL,
FaturaNo varchar (20) NOT NULL,
);

CREATE PROCEDURE sp_recetesatis (@HastaTc char(11), @IlacAdi varchar (50), @Tarih date, @IlacAdet tinyint, @FaturaNo varchar (20))
AS
BEGIN
	INSERT INTO ReceteSatis(HastaTc, IlacAdi, Tarih, Adet, FaturaNo) VALUES (@HastaTc, @IlacAdi, @Tarih, @IlacAdet, @FaturaNo);
END
GO

CREATE PROC sp_receteguncelle (@rId int, @HastaTc char(11), @IlacAdi varchar (50), @Tarih date, @IlacAdet tinyint, @FaturaNo varchar (20))
AS
BEGIN
UPDATE ReceteSatis SET HastaTc = @HastaTc, IlacAdi= @IlacAdi, Tarih=@Tarih, Adet= @IlacAdet, FaturaNo=@FaturaNo WHERE id = @rId
END
GO

CREATE PROC sp_recetesil (@FaturaNo varchar (20))
AS
BEGIN
DELETE FROM ReceteSatis WHERE @FaturaNo = FaturaNo;
END
GO

CREATE PROC sp_recetearamatc (@HastaTc char(11))
AS
BEGIN
SELECT * FROM ReceteSatis WHERE HastaTc LIKE @HastaTc
END
GO

CREATE PROC sp_recetearamafatura ( @FaturaNo varchar (20))
AS
BEGIN
SELECT * FROM ReceteSatis WHERE FaturaNo LIKE @FaturaNo
END
GO

SELECT * FROM ReceteSatis WHERE HastaTc = '31161323223'