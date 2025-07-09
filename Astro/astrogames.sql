-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 16, 2024 at 11:28 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `astrogames`
--

-- --------------------------------------------------------

--
-- Table structure for table `cart`
--

CREATE TABLE `cart` (
  `ID` int(100) NOT NULL,
  `username` varchar(255) NOT NULL,
  `GameID` int(255) NOT NULL,
  `quantity` int(100) NOT NULL,
  `SessionID` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `games`
--

CREATE TABLE `games` (
  `GameID` varchar(255) NOT NULL,
  `Creator` varchar(255) NOT NULL,
  `Price` varchar(255) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Description` varchar(255) NOT NULL,
  `imageCode` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `games`
--

INSERT INTO `games` (`GameID`, `Creator`, `Price`, `Title`, `Description`, `imageCode`) VALUES
('ID0', 'Sledgehammer Games, Treyarch, Infinity Ward, Beenox, Raven Software, High Moon Studios, Demonware', '0', ' Call of Duty: Modern Warfare III\r\n', 'Welcome to Call of Duty HQ, the home of Call of Duty: Modern Warfare III, Call of Duty: Modern Warfare II and Warzone.\r\n', ''),
('ID1', 'Valve', '0', 'Counter-Strike 2\r\n', 'For over two decades, Counter-Strike has offered an elite competitive experience, one shaped by millions of players from across the globe. And now the next chapter in the CS story is about to begin. This is Counter-Strike 2.\r\n', ''),
('ID2', 'Zeekerss', '0', 'Lethal Company', 'A co-op horror about scavenging at abandoned moons to sell scrap to the Company.\r\n', ''),
('ID3', 'Larian Studios', '0', 'Baldur\'s Gate 3', 'Baldur’s Gate 3 is a story-rich, party-based RPG set in the universe of Dungeons & Dragons, where your choices shape a tale of fellowship and betrayal, survival and sacrifice, and the lure of absolute power.\r\n', ''),
('ID4', 'Ubisoft', '0', 'Tom Clancy\'s Rainbow Six siege', 'Tom Clancy\'s Rainbow Six Siege is an elite, tactical team-based shooter where superior planning and execution triumph.\r\n', ''),
('ID5', 'Psyonix LLC', '0', 'Rocket League', 'Rocket League is a high-powered hybrid of arcade-style soccer and vehicular mayhem with easy-to-understand controls and fluid, physics-driven competition. Rocket League includes casual and competitive Online Matches, a fully-featured offline Season Mode, ', ''),
('ID6', 'zxczxczx', '0', 'zxzxxzx', 'zxzzx', 'Baldurs'),
('ID6', 'afasd', '0', 'scszcsz', 'scvzvdzvdzv', '000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `ID` int(100) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `date_of_birth` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`ID`, `username`, `password`, `email`, `date_of_birth`) VALUES
(0, 'Eth1', '$2y$10$89ay0w7GMk6wRQS6k1WycOyKJx5PqkpWGEhSXKtcSrfpivd3z2BAq', 'test!@TEst.com', '2024-01-04'),
(0, 'Eth2', '$2y$10$5Tn78UinDCk5mctEhXXYf.t/tCiqAFACDV463VVsCmi5JBcKFEKeq', 'test!@TEst.com', '2024-01-06');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
