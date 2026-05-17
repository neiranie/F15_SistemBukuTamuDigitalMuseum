# Sistem Buku Tamu Digital Museum
<img width="1919" height="1127" alt="image" src="https://github.com/user-attachments/assets/27caf5dd-8a69-41f4-8fe0-88d498b47c23" />
<img width="1919" height="1126" alt="Screenshot 2026-05-17 234551" src="https://github.com/user-attachments/assets/3041d883-384c-4e42-b77e-be6dfd7b32c1" />
<img width="1918" height="1124" alt="Screenshot 2026-05-17 234610" src="https://github.com/user-attachments/assets/6949bc43-74ba-46d6-9326-20a9ddd9fe9d" />
<img width="1919" height="1127" alt="Screenshot 2026-05-17 234646" src="https://github.com/user-attachments/assets/b089341b-837a-4ed5-9450-5f1baf154297" />
<img width="1907" height="1129" alt="Screenshot 2026-05-17 234702" src="https://github.com/user-attachments/assets/552e99ad-9173-4770-a64c-a0efdb863dad" />

Aplikasi desktop berbasis C# Windows Forms untuk mengelola data kunjungan tamu museum. Terdapat dua role pengguna yaitu Pengunjung dan Petugas.

### Apa itu SQL Injection?
SQL Injection adalah serangan siber di mana penyerang menyisipkan perintah SQL melalui kolom input aplikasi. Tujuannya untuk memanipulasi database, misalnya bypass login tanpa username dan password yang benar.

### Form yang Diuji
Login Petugas

### Percobaan SQL Injection
Penyerang mencoba masuk ke sistem tanpa memiliki akun yang terdaftar dengan cara memasukkan input berikut:

- Username: ' OR '1'='1
- Password: ' OR '1'='1

Jika sistem tidak dilindungi, query yang terbentuk di database akan menjadi seperti ini:

SELECT * FROM Petugas WHERE username = '' OR '1'='1' AND password = '' OR '1'='1'

Karena kondisi '1'='1' selalu bernilai benar, maka sistem yang tidak dilindungi akan mengizinkan siapa saja masuk tanpa verifikasi.
