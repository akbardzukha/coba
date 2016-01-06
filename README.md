Hasil Kelompok Sistem Paralel

1. Mean
2. Linear Regression
3. Max
4. Mean
5. Range
6. Sum
7. Median
8. Standar Deviasi
9. Variansi
10. Modus
11. Median

Modul yang kami buat, berbeda dengan dua kelompok yang sudah maju sebelumnya, yaitu kelompok Anggara Jatmika dan kelompok Yudha. Kelompok Anggara membuat spss parallel dengan fungsi: Modus, Median, Mean, Range, Regresi Linier, Standar Deviasi, Variansi. Sedangkan Yudha hanya membuat fungsi Linear Regression dan Mean.
Kami memilih menggunakan konsep Single Instruction Multiple Data untuk fungsi pada aplikasi yang kami buat. Kami memanfaatkan core Cuda dalam GPU Nvidia dengan SM_20.
Kami melakukan paralel pada fungsi min, max, dan sum. Untuk fungsi median yang menjadi tugas kami sudah kami lakukan dengan paralelisasi penjumlahan namun terjadi error dalam pemanggilan array dalam Cuda. Karena terbatasnya waktu, kamu belum sempat menemukan solusi yang paling tepat. Untuk fungsi yang tidak diparalel (suquential) sudah kami kerjakan sesuai yang disyaratkan, seperti range, median, standar deviasi, modus, dan variansi.

System Requirement untuk membuat aplikasi ini sama dengan kelompok yang sudah maju.

  Software
    1. Windows 10 x64 bit
    2. Visual Studio 2013
    3. CUDA Toolkit v7.5
  Hardware
    1. Nvidia Graphic Card
  Package
    1. Reogrid - .Net Spreadsheet Component v0.9.1.0
    2. Json.Net v7.0.1
    3. CUDAfy.Net v1.29
    
Cara instalasi:
  1. Buka Visual Studio, pada package manager ketik "PM> Install-Package CUDAfy.NET"
  
  
  
  
