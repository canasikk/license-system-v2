-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 12 Şub 2022, 23:39:20
-- Sunucu sürümü: 10.4.22-MariaDB
-- PHP Sürümü: 8.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `licensev2`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `lkey`
--

CREATE TABLE `lkey` (
  `id` int(11) NOT NULL,
  `licenses` text NOT NULL,
  `enddate` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `lkey`
--

INSERT INTO `lkey` (`id`, `licenses`, `enddate`) VALUES
(1, 'a', 'b'),
(2, 'c', 'd'),
(3, '3f9f14f6-3428-495c-82dd-e54688334a38', '13.03.2022'),
(4, '28e1a053-25ee-4920-b60f-3bb8c8269a43', '13.02.2022'),
(5, '4ab2b020-3699-4689-be97-82d2f1a68a45', '13.02.2022'),
(6, '1232893f-49c1-49b6-ae86-c02d62e8cbca', '1.01.2029'),
(7, '69be3283-e88e-445e-81b4-91e20efebc83', '1.01.2029'),
(8, '812fd845-d6b1-4e3f-9c12-c90c4326242e', '1.01.2029'),
(9, 'fde1d88f-ed8f-41e9-90f5-25c445407255', '1.01.2029'),
(10, '1f9831b3-a655-4891-8f6a-040fa6abda6e', '1.01.2029');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `lkey`
--
ALTER TABLE `lkey`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `lkey`
--
ALTER TABLE `lkey`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
