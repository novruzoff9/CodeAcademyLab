#!/bin/bash

# Metin dosyasının okunması
file_path="./list.txt"

# Masaüstü dizini ve hedef klasör
desktop_dir="$HOME/Desktop"
target_dir="$desktop_dir/Nugets"

# Hedef klasörü kontrol et ve oluştur (yoksa)
if [ ! -d "$target_dir" ]; then
    mkdir -p "$target_dir"
    echo "Hedef klasör oluşturuldu -> $target_dir"
else
    echo "Hedef klasör mevcut -> $target_dir"
fi

# Metin dosyasını oku ve her satırdaki dizine git
# while IFS= read -r dir; do
#     echo "fdsapifds"
#     # Her dizin yolunun başındaki ve sonundaki boşlukları temizle
#     dir=$(echo "$dir" | xargs)

#     echo "$dir"
#     # Dizin mevcut mu kontrol et
#     if [ -d "$dir" ]; then
#         echo "Dizin mevcut -> $dir"

#         # Dizin içerisindeki .nupkg dosyalarını taşı
#         find "$dir" -maxdepth 1 -name "*.nupkg" -exec mv {} "$target_dir" \;
#         echo "$dir -> Dizin içerisindeki .nupkg dosyaları taşındı"
#     else
#         echo "Dizin bulunamadı -> $dir"
#     fi
# done < "$file_path"

echo "Taşıma işlemi bitti"

# Scriptin bitiminde bekleme süresi
sleep 3