-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : lun. 11 avr. 2022 à 21:46
-- Version du serveur : 10.4.22-MariaDB
-- Version de PHP : 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `sicilylines`
--

-- --------------------------------------------------------

--
-- Structure de la table `bateau`
--

CREATE TABLE `bateau` (
  `id` int(11) NOT NULL,
  `nom` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `longueur` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `largeur` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `vitesse` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `bateau`
--

INSERT INTO `bateau` (`id`, `nom`, `longueur`, `largeur`, `vitesse`) VALUES
(1, 'Bateau de la Mer', '10Mètres', '8Mètres', '20 noeuds');

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

CREATE TABLE `categorie` (
  `id` int(11) NOT NULL,
  `clibelle` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `categorie`
--

INSERT INTO `categorie` (`id`, `clibelle`) VALUES
(1, 'A.passager'),
(2, 'B.veh.inf.2m'),
(3, 'C.veh.sup.2m');

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE `client` (
  `id` int(11) NOT NULL,
  `nom` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `adresse` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cp` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `ville` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `contenir`
--

CREATE TABLE `contenir` (
  `nb_max` int(11) NOT NULL,
  `la_categorie_id` int(11) NOT NULL,
  `bateau_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `doctrine_migration_versions`
--

CREATE TABLE `doctrine_migration_versions` (
  `version` varchar(191) COLLATE utf8_unicode_ci NOT NULL,
  `executed_at` datetime DEFAULT NULL,
  `execution_time` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `doctrine_migration_versions`
--

INSERT INTO `doctrine_migration_versions` (`version`, `executed_at`, `execution_time`) VALUES
('DoctrineMigrations\\Version20211227001108', '2021-12-27 01:11:14', 56),
('DoctrineMigrations\\Version20211227001204', '2021-12-27 01:12:07', 60),
('DoctrineMigrations\\Version20211227001413', '2021-12-27 01:14:16', 142),
('DoctrineMigrations\\Version20211227001528', '2021-12-27 01:15:30', 60),
('DoctrineMigrations\\Version20211227001635', '2021-12-27 01:16:37', 55),
('DoctrineMigrations\\Version20211227001659', '2021-12-27 01:17:02', 53),
('DoctrineMigrations\\Version20211227001726', '2021-12-27 01:17:28', 54),
('DoctrineMigrations\\Version20211227001753', '2021-12-27 01:18:04', 61),
('DoctrineMigrations\\Version20211227001916', '2021-12-27 01:19:19', 54),
('DoctrineMigrations\\Version20211227002020', '2021-12-27 01:20:23', 211),
('DoctrineMigrations\\Version20211227002204', '2021-12-27 01:22:07', 215),
('DoctrineMigrations\\Version20211227002316', '2021-12-27 01:23:19', 67),
('DoctrineMigrations\\Version20211227002355', '2021-12-27 01:23:58', 53),
('DoctrineMigrations\\Version20211227002416', '2021-12-27 01:24:19', 64),
('DoctrineMigrations\\Version20211227002502', '2021-12-27 01:25:06', 166),
('DoctrineMigrations\\Version20211227002613', '2021-12-27 01:26:16', 138),
('DoctrineMigrations\\Version20211227010341', '2021-12-27 02:03:47', 180),
('DoctrineMigrations\\Version20211227010518', '2021-12-27 02:05:21', 128),
('DoctrineMigrations\\Version20211227010633', '2021-12-27 02:06:36', 145),
('DoctrineMigrations\\Version20211227010715', '2021-12-27 02:07:18', 52),
('DoctrineMigrations\\Version20211227010840', '2021-12-27 02:08:43', 301),
('DoctrineMigrations\\Version20211227010936', '2021-12-27 02:09:38', 57),
('DoctrineMigrations\\Version20211227011042', '2021-12-27 02:10:44', 243),
('DoctrineMigrations\\Version20211227011410', '2021-12-27 02:14:13', 366),
('DoctrineMigrations\\Version20211227012548', '2021-12-27 02:25:52', 286),
('DoctrineMigrations\\Version20211227012940', '2021-12-27 02:29:42', 286),
('DoctrineMigrations\\Version20211227133624', '2021-12-27 14:36:32', 267),
('DoctrineMigrations\\Version20211227134312', '2021-12-27 14:43:22', 285),
('DoctrineMigrations\\Version20211227134427', '2021-12-27 14:44:29', 269),
('DoctrineMigrations\\Version20220316111404', '2022-03-16 12:14:25', 52);

-- --------------------------------------------------------

--
-- Structure de la table `equipement`
--

CREATE TABLE `equipement` (
  `id` int(11) NOT NULL,
  `libelle` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `liaison`
--

CREATE TABLE `liaison` (
  `id` int(11) NOT NULL,
  `duree` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `port_depart_id` int(11) DEFAULT NULL,
  `port_arrivee_id` int(11) DEFAULT NULL,
  `le_secteur_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `liaison`
--

INSERT INTO `liaison` (`id`, `duree`, `port_depart_id`, `port_arrivee_id`, `le_secteur_id`) VALUES
(1, '3H', 1, 2, 1),
(2, '4H40', 9, 2, 5),
(3, '2H00', 6, 8, 3),
(4, '1H30', 3, 5, 4),
(5, '5H10', 3, 5, 2),
(6, '2H40', 10, 7, 5),
(7, '1H45', 8, 4, 2),
(8, '5H00', 4, 1, 1),
(9, '1H20', 1, 6, 1),
(10, '4H40', 8, 2, 2);

-- --------------------------------------------------------

--
-- Structure de la table `participer`
--

CREATE TABLE `participer` (
  `nombre` int(11) NOT NULL,
  `le_type_id` int(11) NOT NULL,
  `la_reservation_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `periode`
--

CREATE TABLE `periode` (
  `id` int(11) NOT NULL,
  `date_debut` date NOT NULL,
  `date_fin` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `periode`
--

INSERT INTO `periode` (`id`, `date_debut`, `date_fin`) VALUES
(1, '2021-09-01', '2022-06-15'),
(2, '2022-06-16', '2022-09-15'),
(3, '2022-09-16', '2023-05-31');

-- --------------------------------------------------------

--
-- Structure de la table `port`
--

CREATE TABLE `port` (
  `id` int(11) NOT NULL,
  `nom` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `port`
--

INSERT INTO `port` (`id`, `nom`) VALUES
(1, 'port de Palerme'),
(2, 'port de Catane'),
(3, 'port piccolo'),
(4, 'port Ulisse'),
(5, 'port Sciacca'),
(6, 'port San Nicola'),
(7, 'port San Leone'),
(8, 'port Arenella'),
(9, 'port Mondello'),
(10, 'port Marina di Ragusa');

-- --------------------------------------------------------

--
-- Structure de la table `proposer`
--

CREATE TABLE `proposer` (
  `qte` int(11) NOT NULL,
  `equipement_id` int(11) NOT NULL,
  `bateau_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

CREATE TABLE `reservation` (
  `id` int(11) NOT NULL,
  `le_client_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `secteur`
--

CREATE TABLE `secteur` (
  `id` int(11) NOT NULL,
  `libelle` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `secteur`
--

INSERT INTO `secteur` (`id`, `libelle`) VALUES
(1, 'secteur A'),
(2, 'secteur B'),
(3, 'secteur C'),
(4, 'secteur D'),
(5, 'secteur E');

-- --------------------------------------------------------

--
-- Structure de la table `tarifer`
--

CREATE TABLE `tarifer` (
  `la_liaison_id` int(11) NOT NULL,
  `la_periode_id` int(11) NOT NULL,
  `le_type_id` int(11) NOT NULL,
  `tarif` float(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `tarifer`
--

INSERT INTO `tarifer` (`la_liaison_id`, `la_periode_id`, `le_type_id`, `tarif`) VALUES
(1, 1, 1, 18),
(1, 1, 2, 11),
(1, 1, 3, 6),
(1, 1, 4, 86),
(1, 1, 5, 129),
(1, 1, 6, 189),
(1, 1, 7, 205),
(1, 1, 8, 268),
(1, 2, 1, 20),
(1, 2, 2, 13),
(1, 2, 3, 7),
(1, 2, 4, 95),
(1, 2, 5, 142),
(1, 2, 6, 208),
(1, 2, 7, 226),
(1, 2, 8, 295),
(1, 3, 1, 19),
(1, 3, 2, 12),
(1, 3, 3, 6),
(1, 3, 4, 91),
(1, 3, 5, 136),
(1, 3, 6, 199),
(1, 3, 7, 216),
(1, 3, 8, 282);

-- --------------------------------------------------------

--
-- Structure de la table `traversee`
--

CREATE TABLE `traversee` (
  `id` int(11) NOT NULL,
  `date` date NOT NULL,
  `heure` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `le_bateau_id` int(11) DEFAULT NULL,
  `la_liaison_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `traversee`
--

INSERT INTO `traversee` (`id`, `date`, `heure`, `le_bateau_id`, `la_liaison_id`) VALUES
(1, '2022-12-10', '15H30', 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `type`
--

CREATE TABLE `type` (
  `id` int(11) NOT NULL,
  `libelle` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `la_categorie_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `type`
--

INSERT INTO `type` (`id`, `libelle`, `la_categorie_id`) VALUES
(1, 'A1.Adulte', 1),
(2, 'A2.Junior', 1),
(3, 'A3.Enfant', 1),
(4, 'B1.Voit.long.4m', 2),
(5, 'B2.Voit.long.5m', 2),
(6, 'C1.Fourgon', 3),
(7, 'C2.CampingCar', 3),
(8, 'C3.Camion', 3);

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `id` int(11) NOT NULL,
  `mail` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `mdp` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nom` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `prenom` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `utilisateur`
--

INSERT INTO `utilisateur` (`id`, `mail`, `mdp`, `nom`, `prenom`) VALUES
(1, 'da@outlook.fr', '1234', 'gnda', 'dany');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `bateau`
--
ALTER TABLE `bateau`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `categorie`
--
ALTER TABLE `categorie`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `contenir`
--
ALTER TABLE `contenir`
  ADD PRIMARY KEY (`la_categorie_id`,`bateau_id`),
  ADD KEY `IDX_3C914DFD281042B9` (`la_categorie_id`),
  ADD KEY `IDX_3C914DFDA9706509` (`bateau_id`);

--
-- Index pour la table `doctrine_migration_versions`
--
ALTER TABLE `doctrine_migration_versions`
  ADD PRIMARY KEY (`version`);

--
-- Index pour la table `equipement`
--
ALTER TABLE `equipement`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `liaison`
--
ALTER TABLE `liaison`
  ADD PRIMARY KEY (`id`),
  ADD KEY `IDX_225AC3794C9CCD3` (`port_depart_id`),
  ADD KEY `IDX_225AC37141EAE06` (`port_arrivee_id`),
  ADD KEY `IDX_225AC37BC7E3BAE` (`le_secteur_id`);

--
-- Index pour la table `participer`
--
ALTER TABLE `participer`
  ADD PRIMARY KEY (`le_type_id`,`la_reservation_id`),
  ADD KEY `IDX_EDBE16F8EA83FAE4` (`le_type_id`),
  ADD KEY `IDX_EDBE16F8BA31B7B` (`la_reservation_id`);

--
-- Index pour la table `periode`
--
ALTER TABLE `periode`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `port`
--
ALTER TABLE `port`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `proposer`
--
ALTER TABLE `proposer`
  ADD PRIMARY KEY (`equipement_id`,`bateau_id`),
  ADD KEY `IDX_21866C15806F0F5C` (`equipement_id`),
  ADD KEY `IDX_21866C15A9706509` (`bateau_id`);

--
-- Index pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`id`),
  ADD KEY `IDX_42C84955C0F37DD6` (`le_client_id`);

--
-- Index pour la table `secteur`
--
ALTER TABLE `secteur`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `tarifer`
--
ALTER TABLE `tarifer`
  ADD PRIMARY KEY (`la_liaison_id`,`la_periode_id`,`le_type_id`),
  ADD KEY `IDX_6904C4FF2ED55551` (`la_liaison_id`),
  ADD KEY `IDX_6904C4FFD382851B` (`la_periode_id`),
  ADD KEY `IDX_6904C4FFEA83FAE4` (`le_type_id`);

--
-- Index pour la table `traversee`
--
ALTER TABLE `traversee`
  ADD PRIMARY KEY (`id`),
  ADD KEY `IDX_B688F501706871FE` (`le_bateau_id`),
  ADD KEY `IDX_B688F5012ED55551` (`la_liaison_id`);

--
-- Index pour la table `type`
--
ALTER TABLE `type`
  ADD PRIMARY KEY (`id`),
  ADD KEY `IDX_8CDE5729281042B9` (`la_categorie_id`);

--
-- Index pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `bateau`
--
ALTER TABLE `bateau`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT pour la table `categorie`
--
ALTER TABLE `categorie`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `client`
--
ALTER TABLE `client`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `equipement`
--
ALTER TABLE `equipement`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `liaison`
--
ALTER TABLE `liaison`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT pour la table `periode`
--
ALTER TABLE `periode`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT pour la table `port`
--
ALTER TABLE `port`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pour la table `reservation`
--
ALTER TABLE `reservation`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `secteur`
--
ALTER TABLE `secteur`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT pour la table `traversee`
--
ALTER TABLE `traversee`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT pour la table `type`
--
ALTER TABLE `type`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `contenir`
--
ALTER TABLE `contenir`
  ADD CONSTRAINT `FK_3C914DFD281042B9` FOREIGN KEY (`la_categorie_id`) REFERENCES `categorie` (`id`),
  ADD CONSTRAINT `FK_3C914DFDA9706509` FOREIGN KEY (`bateau_id`) REFERENCES `bateau` (`id`);

--
-- Contraintes pour la table `liaison`
--
ALTER TABLE `liaison`
  ADD CONSTRAINT `FK_225AC37141EAE06` FOREIGN KEY (`port_arrivee_id`) REFERENCES `port` (`id`),
  ADD CONSTRAINT `FK_225AC3794C9CCD3` FOREIGN KEY (`port_depart_id`) REFERENCES `port` (`id`),
  ADD CONSTRAINT `FK_225AC37BC7E3BAE` FOREIGN KEY (`le_secteur_id`) REFERENCES `secteur` (`id`);

--
-- Contraintes pour la table `participer`
--
ALTER TABLE `participer`
  ADD CONSTRAINT `FK_EDBE16F8BA31B7B` FOREIGN KEY (`la_reservation_id`) REFERENCES `reservation` (`id`),
  ADD CONSTRAINT `FK_EDBE16F8EA83FAE4` FOREIGN KEY (`le_type_id`) REFERENCES `type` (`id`);

--
-- Contraintes pour la table `proposer`
--
ALTER TABLE `proposer`
  ADD CONSTRAINT `FK_21866C15806F0F5C` FOREIGN KEY (`equipement_id`) REFERENCES `equipement` (`id`),
  ADD CONSTRAINT `FK_21866C15A9706509` FOREIGN KEY (`bateau_id`) REFERENCES `bateau` (`id`);

--
-- Contraintes pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `FK_42C84955C0F37DD6` FOREIGN KEY (`le_client_id`) REFERENCES `client` (`id`);

--
-- Contraintes pour la table `tarifer`
--
ALTER TABLE `tarifer`
  ADD CONSTRAINT `FK_6904C4FF2ED55551` FOREIGN KEY (`la_liaison_id`) REFERENCES `liaison` (`id`),
  ADD CONSTRAINT `FK_6904C4FFD382851B` FOREIGN KEY (`la_periode_id`) REFERENCES `periode` (`id`),
  ADD CONSTRAINT `FK_6904C4FFEA83FAE4` FOREIGN KEY (`le_type_id`) REFERENCES `type` (`id`);

--
-- Contraintes pour la table `traversee`
--
ALTER TABLE `traversee`
  ADD CONSTRAINT `FK_B688F5012ED55551` FOREIGN KEY (`la_liaison_id`) REFERENCES `liaison` (`id`),
  ADD CONSTRAINT `FK_B688F501706871FE` FOREIGN KEY (`le_bateau_id`) REFERENCES `bateau` (`id`);

--
-- Contraintes pour la table `type`
--
ALTER TABLE `type`
  ADD CONSTRAINT `FK_8CDE5729281042B9` FOREIGN KEY (`la_categorie_id`) REFERENCES `categorie` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
