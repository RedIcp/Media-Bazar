-- Gegenereerd op: 12 okt 2021 om 10:56
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
-- Tabelstructuur voor tabel `atendance`
--

CREATE TABLE `atendance` (
  `Check` int(11) NOT NULL,
  `EmployeeID` int(11) NOT NULL,
  `CheckInTime` time NOT NULL DEFAULT '00:00:00',
  `CheckOutTime` time DEFAULT '00:00:00',
  `CheckDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `atendance`
--

INSERT INTO `atendance` (`Check`, `EmployeeID`, `CheckInTime`, `CheckOutTime`, `CheckDate`) VALUES
(2, 9, '19:12:12', '20:20:02', '2020-12-12 00:00:00'),
(3, 9, '13:59:50', '13:59:50', '2021-09-29 00:00:00'),
(4, 9, '10:26:59', NULL, '2021-10-07 00:00:00'),
(5, 9, '10:28:58', NULL, '2021-10-07 00:00:00'),
(6, 15, '10:33:57', '13:18:50', '2021-10-07 00:00:00'),
(7, 15, '10:46:17', '13:18:50', '2021-10-07 00:00:00'),
(8, 15, '11:57:44', '13:18:50', '2021-10-07 00:00:00'),
(9, 19, '11:57:55', NULL, '2021-10-07 00:00:00'),
(10, 15, '12:06:42', '13:18:50', '2021-10-07 00:00:00'),
(11, 15, '12:07:53', '13:18:50', '2021-10-07 00:00:00'),
(12, 15, '13:18:38', '13:18:50', '2021-10-07 00:00:00'),
(13, 18, '14:13:50', NULL, '2021-10-11 00:00:00'),
(14, 18, '14:14:05', NULL, '2021-10-11 00:00:00');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `contract`
--

CREATE TABLE `contract` (
  `ContractID` int(11) NOT NULL,
  `EmployeeID` int(11) NOT NULL,
  `JodTitle` varchar(45) NOT NULL,
  `WorkHoursPerWeek` int(11) NOT NULL,
  `SalaryPerHour` int(11) NOT NULL,
  `StartDate` date NOT NULL,
  `EndDate` date DEFAULT NULL,
  `ReasonForTermination` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `contract`
--

INSERT INTO `contract` (`ContractID`, `EmployeeID`, `JodTitle`, `WorkHoursPerWeek`, `SalaryPerHour`, `StartDate`, `EndDate`, `ReasonForTermination`) VALUES
(28, 9, 'OWNER', 40, 100, '2021-09-01', NULL, NULL),
(29, 10, 'SALES EMPLOYEE', 40, 100, '2021-09-01', NULL, NULL),
(30, 11, 'SALES EMPLOYEE', 40, 100, '2021-09-01', NULL, NULL),
(31, 12, 'SALES EMPLOYEE', 40, 100, '2021-09-01', NULL, NULL),
(32, 13, 'SALES EMPLOYEE', 40, 100, '2021-09-01', NULL, NULL),
(33, 14, 'SALES EMPLOYEE', 40, 100, '2021-09-01', NULL, NULL),
(34, 15, 'DEPOT EMPLOYEE', 40, 100, '2021-09-01', NULL, NULL),
(35, 16, 'DEPOT EMPLOYEE', 40, 100, '2021-09-01', NULL, NULL),
(36, 17, 'DEPOT EMPLOYEE', 40, 100, '2021-09-01', NULL, NULL),
(37, 18, 'DEPOT EMPLOYEE', 40, 100, '2021-09-01', NULL, NULL),
(38, 19, 'OFFICE EMPLOYEE', 40, 100, '2021-09-01', '2021-10-31', 'Bye'),
(39, 20, 'OFFICE EMPLOYEE', 40, 100, '2021-09-01', '2021-10-31', 'Bye'),
(40, 21, 'OFFICE EMPLOYEE', 40, 100, '2021-09-01', NULL, NULL),
(41, 22, 'OFFICE EMPLOYEE', 40, 100, '2021-09-01', '2021-10-31', 'Bye'),
(42, 27, 'OFFICE EMPLOYEE', 48, 465, '2021-09-01', '2021-10-31', 'Bye'),
(43, 23, 'SALES MANAGER', 40, 100, '2021-09-01', NULL, NULL),
(44, 24, 'DEPOT MANAGER', 40, 100, '2021-09-01', NULL, NULL),
(45, 25, 'OFFICE MANAGER', 40, 100, '2021-09-01', NULL, NULL);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `employee`
--

CREATE TABLE `employee` (
  `EmployeeID` int(11) NOT NULL,
  `FirstName` varchar(45) NOT NULL,
  `LastName` varchar(45) NOT NULL,
  `UserName` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `BSN` int(11) NOT NULL,
  `Active` tinyint(4) NOT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `PhoneNumber` int(11) DEFAULT NULL,
  `DateOfBirth` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `employee`
--

INSERT INTO `employee` (`EmployeeID`, `FirstName`, `LastName`, `UserName`, `Password`, `BSN`, `Active`, `Address`, `Email`, `PhoneNumber`, `DateOfBirth`) VALUES
(9, 'Lars', 'Kluijtmans', 'Lars', '1', 1234, 1, '1996', 'lars@gmail.com', 0, '0000-00-00'),
(10, 'Esther', 'wolfs', 'Esther', '1', 1234, 1, '1996', 'lars@gmail.com', 123456789, '0000-00-00'),
(11, 'Lars', 'Kluijtmans', 'Lars', '1', 1234, 1, '1996', 'lars@gmail.com', 0, '2000-01-01'),
(12, 'Lars', 'Kluijtmans', 'Lars', '1', 1234, 1, '1996', 'lars@gmail.com', 0, '0000-00-00'),
(13, 'Kluijtmans', 'Lars', 'Lars', '1', 1234, 1, '1996', 'lars@gmail.com', 0, '0000-00-00'),
(14, 'Lars', 'Kluijtmans', 'Lars', '1', 1234, 1, '1996', 'lars@gmail.com', 0, '0000-00-00'),
(15, 'Lars', 'Kluijtmans', 'Lars', '1', 1234, 1, '1996', 'lars@gmail.com', 0, '0000-00-00'),
(16, 'Lars', 'Kluijtmans', 'Lars', '1', 1234, 1, '1996', 'lars@gmail.com', 0, '0000-00-00'),
(17, 'Kluijtmans', 'Lars', 'Lars', '1', 1234, 1, '1996', 'lars@gmail.com', 1, '0000-00-00'),
(18, 'Kluijtmans', 'Lars', 'Lars', '1', 1234, 1, 'Eindhoven', 'lars@gmail.com', 123456, '0000-00-00'),
(19, 'Lars', 'Kluijtmans', 'Lars', '1', 1234, 0, '1996', 'lars@gmail.com', 0, '0000-00-00'),
(20, 'Lars', 'Kluijtmans', 'Lars', '1', 1234, 0, '1996', 'lars@gmail.com', 0, '0000-00-00'),
(21, 'Lars', 'Kluijtmans', 'Lars', '1', 1234, 1, '1996', 'lars@gmail.com', 0, '0000-00-00'),
(22, 'Lars', 'Kluijtmans', 'Lars', '1', 1234, 0, '1996', 'lars@gmail.com', 0, '0000-00-00'),
(23, 'Esther', 'Wolfs', 'Wolfs', 'Wolfs', 123456, 1, 'Den Bosch', 'Wolfs@mb.com', 132456789, NULL),
(24, 'Esther', 'Wolfs', 'Wolfs', 'Wolfs', 54545, 1, 'Amsterdam', 'Wolfs@mb.com', 458784, NULL),
(25, 'Esther', 'Wolfs', 'Wolfs', 'Wolfs', 789798, 1, 'Heusden', 'Wolfs@mb.com', 456789, NULL),
(26, 'Esther', 'Wolfs', 'Wolfs', 'Wolfs', 789798, 1, 'Heusden', 'Wolfs@mb.com', 456789, NULL),
(27, 'test', 'test', 'test', 'test', 12345, 0, 'test', 'test@mb.com', 546546, NULL),
(28, 'Lars', 'Kluijtmans', 'Lars', '1', 1234, 1, '1996', 'lars@gmail.com', 0, '0000-00-00'),
(29, 'Lars', 'Kluijtmans', 'Lars', '1', 1234, 0, '1996', 'lars@gmail.com', 0, '0000-00-00'),
(30, 'Lars', 'Kluijtmans', 'Lars', '1', 1234, 1, '1996', 'lars@gmail.com', 0, '0000-00-00'),
(31, 'Henk', 'Jansen', 'Jansen', 'Jansen', 111222, 1, 'Eindhoven', 'Jansen@mb.com', 698765432, NULL),
(32, 'jon', 'jonsen', 'jonsen', 'jonsen', 11, 1, 'your mom', 'jonsen@mb.com', 124, NULL),
(33, 'q', 'q', 'q', 'q', 1, 0, 'e4w32', 'q@mb.com', 1, NULL),
(34, 'q', 'q', 'q', 'q', 1, 1, 'e4w32', 'q@mb.com', 1, NULL),
(35, 'jon', 'q', 'q', 'q', 1, 1, 'q', 'q@mb.com', 1, NULL),
(36, 'ddsds1212', 'ttd343', 'ddsds', 'ddsds', 1234, 1, 'eindhoven', 'ddsds@mb.com', 123, NULL);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `jobs`
--

CREATE TABLE `jobs` (
  `JobID` int(11) NOT NULL,
  `JobTitle` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `jobs`
--

INSERT INTO `jobs` (`JobID`, `JobTitle`) VALUES
(23, 'OWNER'),
(24, 'SALES EMPLOYEE'),
(25, 'SALES MANAGER'),
(26, 'DEPOT EMPLOYEE'),
(27, 'DEPOT MANAGER'),
(28, 'OFFICE EMPLOYEE'),
(29, 'OFFICE MANAGER');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `product`
--

CREATE TABLE `product` (
  `ProductID` int(11) NOT NULL,
  `Name` varchar(45) NOT NULL,
  `Barcode` varchar(45) DEFAULT NULL,
  `Type` varchar(45) NOT NULL,
  `AmountInStore` int(11) NOT NULL DEFAULT '0',
  `AmountInDepot` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `product`
--

INSERT INTO `product` (`ProductID`, `Name`, `Barcode`, `Type`, `AmountInStore`, `AmountInDepot`) VALUES
(1, 'Knife', 'KIT1', 'KITCHEN_HOME', 308, 328),
(11, 'banana', 'KIT11', 'KITCHEN_HOME', 1, 1),
(19, 'apple', 'KIT19', 'KITCHEN_HOME', 12, 14),
(21, 'SuperMario', 'PHO21', 'PHOTO_VIDEO_NAVIGATION', 2, 270),
(22, 'SuperMarioBros2', 'PHO22', 'PHOTO_VIDEO_NAVIGATION', 1, 110),
(25, 'Amazing game', 'PHO25', 'PHOTO_VIDEO_NAVIGATION', 112, 0),
(28, 'Yolo', 'kk', 'SMARTHOME_APPLIANCES', 171, 129),
(31, 'Mario Kart', 'PHO1', 'PHOTO_VIDEO_NAVIGATION', 100, 200),
(33, 'SuperMarioBros2', 'PHO22', 'PHOTO_VIDEO_NAVIGATION', 110, 1090),
(35, 'Knife', 'k1', 'Kitchen and Home', 100, 100),
(36, 'Big Knife', 'k2', 'Kitchen and Home', 115, 85),
(37, 'fork', 'k1', 'KITCHEN_HOME', 1, 100),
(39, 'Computer', 'k2', 'Photo video and navigation', 100, 100),
(41, 'Smart fork', 'k1', 'GAMING_MUSIC_COMPUTERS', 100, 100),
(42, 'Oven', 'k2', 'Smart home apliances', 110, 90),
(43, 'Microwave', 'k1', 'Smart home apliances', 100, 100),
(45, 'Big Game', 'k2', 'Gaming music computers', 100, 100),
(46, 'Game', 'k1', 'Gaming music computers', 100, 115),
(48, 'Pokemon', 'GAM1', 'GAMING_MUSIC_COMPUTERS', 39, 3),
(51, 'SuperMarioBros3', 'PHO22', 'PHOTO_VIDEO_NAVIGATION', 1, 110),
(52, 'fork', 'k1', 'KITCHEN_HOME', 100, 100),
(53, 'fork', 'k1', 'KITCHEN_HOME', 100, 100),
(55, 'Pokemon', 'GAM1', 'GAMING_MUSIC_COMPUTERS', 39, 3),
(56, 'Mario Kart', 'PHO1', 'PHOTO_VIDEO_NAVIGATION', 100, 200),
(57, 'fork', 'k1', 'KITCHEN_HOME', 1, 1);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `producttype`
--

CREATE TABLE `producttype` (
  `TypeID` int(11) NOT NULL,
  ` ProductType` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `producttype`
--

INSERT INTO `producttype` (`TypeID`, ` ProductType`) VALUES
(25, 'Kitchen and Home'),
(26, 'Photo video and navigation'),
(27, 'Smart home apliances'),
(28, 'Gaming music computers');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `restockreplenishment`
--

CREATE TABLE `restockreplenishment` (
  `RestockReplenishmentID` int(11) NOT NULL,
  `ProductID` int(11) NOT NULL,
  `Amount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `restockreplenishment`
--

INSERT INTO `restockreplenishment` (`RestockReplenishmentID`, `ProductID`, `Amount`) VALUES
(37, 31, 100),
(40, 33, 25),
(41, 46, 15),
(42, 21, 111);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `schduledwork`
--

CREATE TABLE `schduledwork` (
  `WorkID` int(11) NOT NULL,
  `Department` varchar(45) NOT NULL,
  `EmployeeID` int(11) NOT NULL,
  `Day` varchar(45) NOT NULL,
  `Time` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `schduledwork`
--

INSERT INTO `schduledwork` (`WorkID`, `Department`, `EmployeeID`, `Day`, `Time`) VALUES
(818, 'Sales', 12, 'Friday', 'Morning'),
(819, 'Sales', 23, 'Friday', 'Afternoon'),
(820, 'Sales', 11, 'Friday', 'Evening'),
(821, 'Sales', 13, 'Saterday', 'Morning'),
(822, 'Sales', 13, 'Saterday', 'Afternoon'),
(823, 'Sales', 10, 'Saterday', 'Evening'),
(824, 'Sales', 13, 'Sunday', 'Morning'),
(825, 'Sales', 14, 'Sunday', 'Afternoon'),
(826, 'Sales', 23, 'Sunday', 'Evening'),
(827, 'Depot', 0, 'Monday', 'Morning'),
(828, 'Depot', 0, 'Monday', 'Afternoon'),
(829, 'Depot', 0, 'Monday', 'Evening'),
(830, 'Depot', 0, 'Tusday', 'Morning'),
(831, 'Depot', 0, 'Tusday', 'Afternoon'),
(832, 'Depot', 0, 'Tusday', 'Evening'),
(833, 'Depot', 0, 'Wednesday', 'Morning'),
(834, 'Depot', 0, 'Wednesday', 'Afternoon'),
(835, 'Depot', 0, 'Wednesday', 'Evening'),
(836, 'Depot', 0, 'Thursday', 'Morning'),
(837, 'Depot', 0, 'Thursday', 'Afternoon'),
(838, 'Depot', 0, 'Thursday', 'Evening'),
(839, 'Depot', 0, 'Friday', 'Morning'),
(840, 'Depot', 0, 'Friday', 'Afternoon'),
(841, 'Depot', 0, 'Friday', 'Evening'),
(842, 'Depot', 0, 'Saterday', 'Morning'),
(843, 'Depot', 0, 'Saterday', 'Afternoon'),
(844, 'Depot', 0, 'Saterday', 'Evening'),
(845, 'Depot', 0, 'Sunday', 'Morning'),
(846, 'Depot', 0, 'Sunday', 'Afternoon'),
(847, 'Depot', 0, 'Sunday', 'Afternoon'),
(848, 'Depot', 0, 'Sunday', 'Afternoon'),
(849, 'Depot', 0, 'Sunday', 'Evening'),
(850, 'Depot', 0, 'Sunday', 'Evening'),
(851, 'Depot', 0, 'Sunday', 'Evening'),
(852, 'Depot', 0, 'Sunday', 'Evening'),
(853, 'Depot', 0, 'Sunday', 'Evening'),
(854, 'Office', 0, 'Monday', 'Morning'),
(855, 'Office', 0, 'Monday', 'Afternoon'),
(856, 'Office', 0, 'Monday', 'Evening'),
(857, 'Office', 0, 'Tusday', 'Morning'),
(858, 'Office', 0, 'Tusday', 'Afternoon'),
(859, 'Office', 0, 'Tusday', 'Evening'),
(860, 'Office', 0, 'Wednesday', 'Morning'),
(861, 'Office', 0, 'Wednesday', 'Afternoon'),
(862, 'Office', 0, 'Wednesday', 'Evening'),
(863, 'Office', 0, 'Thursday', 'Morning'),
(864, 'Office', 0, 'Thursday', 'Afternoon'),
(865, 'Office', 0, 'Thursday', 'Evening'),
(866, 'Office', 0, 'Friday', 'Morning'),
(867, 'Office', 0, 'Friday', 'Afternoon'),
(868, 'Office', 0, 'Friday', 'Evening'),
(869, 'Office', 0, 'Saterday', 'Morning'),
(870, 'Office', 0, 'Saterday', 'Afternoon'),
(871, 'Office', 0, 'Saterday', 'Evening'),
(872, 'Office', 0, 'Sunday', 'Morning'),
(873, 'Office', 0, 'Sunday', 'Afternoon'),
(874, 'Office', 0, 'Sunday', 'Evening');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `schedule`
--

CREATE TABLE `schedule` (
  `ScheduleID` int(11) NOT NULL,
  `Department` varchar(45) NOT NULL,
  `Day` varchar(45) NOT NULL,
  `Morning` int(11) NOT NULL DEFAULT '1',
  `Afternoon` int(11) NOT NULL DEFAULT '1',
  `Evening` int(11) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `schedule`
--

INSERT INTO `schedule` (`ScheduleID`, `Department`, `Day`, `Morning`, `Afternoon`, `Evening`) VALUES
(1, 'Sales', 'Monday', 1, 1, 0),
(2, 'Sales', 'Tusday', 1, 1, 1),
(3, 'Sales', 'Wednesday', 0, 0, 0),
(4, 'Sales', 'Thursday', 0, 0, 0),
(5, 'Sales', 'Friday', 1, 1, 1),
(6, 'Sales', 'Saterday', 1, 1, 1),
(7, 'Sales', 'Sunday', 1, 1, 1),
(8, 'Depot', 'Monday', 1, 1, 1),
(9, 'Depot', 'Tusday', 1, 1, 1),
(10, 'Depot', 'Wednesday', 1, 1, 1),
(11, 'Depot', 'Thursday', 1, 1, 1),
(12, 'Depot', 'Friday', 1, 1, 1),
(13, 'Depot', 'Saterday', 1, 1, 1),
(14, 'Depot', 'Sunday', 1, 1, 1),
(15, 'Office', 'Monday', 1, 1, 1),
(16, 'Office', 'Tusday', 1, 1, 1),
(17, 'Office', 'Wednesday', 1, 1, 1),
(18, 'Office', 'Thursday', 1, 1, 1),
(19, 'Office', 'Friday', 1, 1, 1),
(20, 'Office', 'Saterday', 1, 1, 1),
(21, 'Office', 'Sunday', 0, 0, 0);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `shelfreplenishment`
--

CREATE TABLE `shelfreplenishment` (
  `ShelfReplenishmentID` int(11) NOT NULL,
  `ProductID` int(11) NOT NULL,
  `Amount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `shelfreplenishment`
--

INSERT INTO `shelfreplenishment` (`ShelfReplenishmentID`, `ProductID`, `Amount`) VALUES
(48, 36, 10),
(49, 51, 10),
(50, 31, 10),
(51, 19, 10),
(52, 33, 10),
(53, 33, 100),
(54, 28, 11);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `workprefrance`
--

CREATE TABLE `workprefrance` (
  `PrefranceID` int(11) NOT NULL,
  `EmployeeID` int(11) NOT NULL,
  `Prefered` tinyint(4) NOT NULL,
  `Day` varchar(45) DEFAULT NULL,
  `Time` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `workprefrance`
--

INSERT INTO `workprefrance` (`PrefranceID`, `EmployeeID`, `Prefered`, `Day`, `Time`) VALUES
(2, 9, 1, 'Monday', 'Morning'),
(3, 10, 1, 'Thursday', 'Afternon'),
(4, 11, 1, 'Wednesday', 'Afternon'),
(5, 12, 1, 'Friday', 'Evening'),
(6, 13, 1, 'Monday', 'Afternon'),
(7, 14, 1, 'Wednesday', 'Morning'),
(8, 15, 1, 'Friday', 'Evening'),
(9, 16, 1, 'Monday', 'Morning'),
(10, 17, 1, 'Wednesday', 'Afternon'),
(11, 18, 1, 'Saterday', 'Morning'),
(12, 19, 1, 'Thursday', 'Afternon'),
(13, 20, 1, 'Wednesday', 'Evening'),
(14, 21, 1, 'Monday', 'Afternon'),
(15, 22, 1, 'Monday', 'Afternon'),
(16, 9, 0, 'Friday', 'Evening'),
(17, 10, 0, 'Thursday', 'Afternon'),
(18, 11, 0, 'Saterday', 'Morning'),
(19, 12, 0, 'Monday', 'Evening'),
(20, 13, 0, 'Monday', 'Evening'),
(21, 14, 0, 'Wednesday', 'Morning'),
(22, 15, 0, 'Monday', 'Evening'),
(23, 16, 0, 'Friday', 'Afternon'),
(24, 17, 0, 'Monday', 'Morning'),
(25, 18, 0, 'Wednesday', 'Evening'),
(26, 19, 0, 'Sunday', 'Morning'),
(27, 20, 0, 'Friday', 'Evening'),
(28, 21, 0, 'Wednesday', 'Evening'),
(29, 22, 0, 'Sunday', 'Evening');

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `atendance`
--
ALTER TABLE `atendance`
  ADD PRIMARY KEY (`Check`);

--
-- Indexen voor tabel `contract`
--
ALTER TABLE `contract`
  ADD PRIMARY KEY (`ContractID`),
  ADD KEY `employeeID_idx` (`EmployeeID`);

--
-- Indexen voor tabel `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`EmployeeID`);

--
-- Indexen voor tabel `jobs`
--
ALTER TABLE `jobs`
  ADD PRIMARY KEY (`JobID`);

--
-- Indexen voor tabel `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`ProductID`);

--
-- Indexen voor tabel `producttype`
--
ALTER TABLE `producttype`
  ADD PRIMARY KEY (`TypeID`);

--
-- Indexen voor tabel `restockreplenishment`
--
ALTER TABLE `restockreplenishment`
  ADD PRIMARY KEY (`RestockReplenishmentID`),
  ADD KEY `ProductID_idx` (`ProductID`);

--
-- Indexen voor tabel `schduledwork`
--
ALTER TABLE `schduledwork`
  ADD PRIMARY KEY (`WorkID`);

--
-- Indexen voor tabel `schedule`
--
ALTER TABLE `schedule`
  ADD PRIMARY KEY (`ScheduleID`);

--
-- Indexen voor tabel `shelfreplenishment`
--
ALTER TABLE `shelfreplenishment`
  ADD PRIMARY KEY (`ShelfReplenishmentID`),
  ADD KEY `ProductID_idx` (`ProductID`);

--
-- Indexen voor tabel `workprefrance`
--
ALTER TABLE `workprefrance`
  ADD PRIMARY KEY (`PrefranceID`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `atendance`
--
ALTER TABLE `atendance`
  MODIFY `Check` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT voor een tabel `contract`
--
ALTER TABLE `contract`
  MODIFY `ContractID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;

--
-- AUTO_INCREMENT voor een tabel `employee`
--
ALTER TABLE `employee`
  MODIFY `EmployeeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT voor een tabel `jobs`
--
ALTER TABLE `jobs`
  MODIFY `JobID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT voor een tabel `product`
--
ALTER TABLE `product`
  MODIFY `ProductID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=58;

--
-- AUTO_INCREMENT voor een tabel `producttype`
--
ALTER TABLE `producttype`
  MODIFY `TypeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT voor een tabel `restockreplenishment`
--
ALTER TABLE `restockreplenishment`
  MODIFY `RestockReplenishmentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- AUTO_INCREMENT voor een tabel `schduledwork`
--
ALTER TABLE `schduledwork`
  MODIFY `WorkID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=875;

--
-- AUTO_INCREMENT voor een tabel `shelfreplenishment`
--
ALTER TABLE `shelfreplenishment`
  MODIFY `ShelfReplenishmentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=55;

--
-- AUTO_INCREMENT voor een tabel `workprefrance`
--
ALTER TABLE `workprefrance`
  MODIFY `PrefranceID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- Beperkingen voor geëxporteerde tabellen
--

--
-- Beperkingen voor tabel `contract`
--
ALTER TABLE `contract`
  ADD CONSTRAINT `employeeID` FOREIGN KEY (`EmployeeID`) REFERENCES `employee` (`EmployeeID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Beperkingen voor tabel `restockreplenishment`
--
ALTER TABLE `restockreplenishment`
  ADD CONSTRAINT `productID2` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Beperkingen voor tabel `shelfreplenishment`
--
ALTER TABLE `shelfreplenishment`
  ADD CONSTRAINT `ProductID` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
