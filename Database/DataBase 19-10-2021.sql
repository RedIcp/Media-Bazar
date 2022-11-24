-- phpMyAdmin SQL Dump
-- version 4.9.3
-- https://www.phpmyadmin.net/
--
-- Host: studmysql01.fhict.local
-- Gegenereerd op: 19 okt 2021 om 14:56
-- Serverversie: 5.7.26-log
-- PHP-versie: 7.4.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbi461266`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `attendance`
--

CREATE TABLE `attendance` (
  `Check` int(11) NOT NULL,
  `EmployeeID` int(11) NOT NULL,
  `CheckInTime` time NOT NULL DEFAULT '00:00:00',
  `CheckOutTime` time DEFAULT '00:00:00',
  `CheckDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `attendance`
--

INSERT INTO `attendance` (`Check`, `EmployeeID`, `CheckInTime`, `CheckOutTime`, `CheckDate`) VALUES
(1, 15, '11:40:08', '11:40:14', '2021-10-19 00:00:00'),
(2, 10, '11:42:09', '11:42:15', '2021-10-19 00:00:00'),
(3, 10, '11:42:27', '11:42:33', '2021-10-19 00:00:00'),
(4, 10, '11:42:41', '11:42:48', '2021-10-19 00:00:00'),
(5, 10, '11:42:54', '11:43:00', '2021-10-19 00:00:00'),
(6, 11, '11:43:06', '11:43:24', '2021-10-19 00:00:00'),
(7, 10, '11:43:41', '11:43:57', '2021-10-19 00:00:00'),
(8, 11, '11:43:45', '11:44:07', '2021-10-19 00:00:00'),
(9, 9, '11:43:48', '12:54:59', '2021-10-19 00:00:00'),
(10, 15, '11:43:51', '12:37:42', '2021-10-19 00:00:00'),
(11, 11, '11:44:13', '12:57:51', '2021-10-19 00:00:00'),
(12, 15, '12:54:56', '14:09:44', '2021-10-19 00:00:00'),
(13, 9, '12:58:03', '12:58:10', '2021-10-19 00:00:00'),
(14, 11, '14:08:35', '14:08:44', '2021-10-19 00:00:00'),
(15, 12, '14:09:22', '14:09:52', '2021-10-19 00:00:00'),
(16, 10, '14:09:37', NULL, '2021-10-19 00:00:00'),
(17, 11, '14:09:49', NULL, '2021-10-19 00:00:00');

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `attendance`
--
ALTER TABLE `attendance`
  ADD PRIMARY KEY (`Check`),
  ADD KEY `EmployeeID` (`EmployeeID`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `attendance`
--
ALTER TABLE `attendance`
  MODIFY `Check` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- Beperkingen voor geëxporteerde tabellen
--

--
-- Beperkingen voor tabel `attendance`
--
ALTER TABLE `attendance`
  ADD CONSTRAINT `attendance_ibfk_1` FOREIGN KEY (`EmployeeID`) REFERENCES `employee` (`EmployeeID`),
  ADD CONSTRAINT `attendance_ibfk_2` FOREIGN KEY (`EmployeeID`) REFERENCES `employee` (`EmployeeID`),
  ADD CONSTRAINT `attendance_ibfk_3` FOREIGN KEY (`EmployeeID`) REFERENCES `employee` (`EmployeeID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
