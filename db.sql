-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: departament_security
-- ------------------------------------------------------
-- Server version	8.0.32

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client` (
  `id` int NOT NULL AUTO_INCREMENT,
  `surname` varchar(45) NOT NULL,
  `name` varchar(45) NOT NULL,
  `patronymic` varchar(45) NOT NULL,
  `organization` varchar(45) DEFAULT NULL,
  `phoneNumber` varchar(45) NOT NULL,
  `passport` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (1,'Иванов','Иван','Иванович','ООО Ромашка','89001234567','1234567890'),(2,'Петров','Петр','Петрович','ЗАО Лес','89007654321','9876543210'),(3,'Сидоров','Сидор','Сидорович','УП Луна','89004561234','1230984567'),(4,'Кузнецов','Алексей','Игоревич','Компания Свет','89002345678','4567891234'),(5,'Попов','Александр','Дмитриевич','Корпорация Мечта','89003456789','5678901234'),(6,'Семенов','Семен','Семенович','ИП Волна','89009876543','1234567891'),(7,'Морозов','Дмитрий','Александрович','Фирма Солнце','89005678901','2345678901'),(8,'Ковалев','Анатолий','Степанович','ТСН Грин','89006789012','3456789012'),(9,'Федоров','Федор','Федорович','ОАО Сибирь','89007890123','4567890123'),(10,'Степанов','Степан','Степанович','АГК Старая','89008901234','5678901234'),(11,'Зайцев','Виктор','Сергеевич','Промышленность','89009012345','6789012345'),(12,'Щербаков','Роман','Васильевич','Торговый дом','89001123456','7890123456'),(13,'Соловьев','Максим','Михайлович','Логистика','89002234567','8901234567'),(14,'Лебедев','Константин','Денисович','ЭнергоТех','89003345678','9012345678'),(15,'Тихонов','Григорий','Анатольевич','Техно-Систем','89004456789','9876543211'),(16,'Килин','Олег','Станиславович','АгроКомплекс','89005567890','8765432101'),(17,'Авдеев','Станислав','Алексеевич','Строительные Материалы','89006678901','6543210987'),(18,'Калинин','Василий','Николаевич','МедТек','89007789012','5432109876'),(19,'Маликов','Денис','Владимирович','Наука и Технологии','89008890123','4321098765'),(20,'Кононов','Никита','Сергеевич','ЭкоМир','89009901234','3210987654'),(21,'Баранов','Владимир','Романович','ЭкспортИмпорт','89001122334','2109876543'),(22,'Устинов','Евгений','Михайлович','ИТ-Решения','89002233445','1098765432'),(23,'Кулешов','Андрей','Денисович','Гермес','89003344556','9876543212'),(24,'Ильиных','Арсений','Львович','ПромКачество','89004455667','8765432103'),(25,'Спиридонов','Павел','Ярославович','Телеком','89005566778','7654321093'),(26,'Быков','Роман','Викторович','АвтоДел','89006677889','6543210982'),(27,'Суриков','Егор','Романович','ФинГрупп','89007788990','5432109871'),(28,'Громов','Алексей','Сергеевич','ТехноИнвест','89008890012','4321098760'),(29,'Казаков','Виктор','Анатольевич','Галактика','89009901223','3210987659'),(30,'Ловцов','Игорь','Иванович','Космос','89091123456','2109876548'),(31,'Крылов','Матвей','Денисович','Архитектура','89002234567','1098765437'),(32,'Касаткин','Станислав','Станиславович','МедиаСервисы','89003345678','9876543216'),(33,'Никитин','Сергей','Игоревич','Капитал','89004456789','8765432105'),(34,'Корнилов','Андрей','Арсеньевич','Туризм','89005567890','7654321094'),(35,'Романов','Евгений','Максимович','СтройТек','89006678901','6543210983'),(36,'Широков','Дмитрий','Павлович','Спорт','89007789012','5432109872'),(37,'Фролов','Николай','Семенович','Кулинария','89008890123','4321098761'),(38,'Горбачёв','Александр','Артурович','Интернет','89009901234','3210987658'),(39,'Лесков','Сергей','Валерьевич','Финансовые Услуги','89091122334','2109876547'),(40,'Ивашков','Юрий','','ПАО \"Ковернинский автопарк\"','+7 (952) 478-92-37','2013 412345'),(41,'dfsaf','asdfgasdgsdgfsdfg','dsfgdsgsadfg','asdfgsdf','+7 (131) 221-41-41','2312 412312'),(42,'dsfsaf','safdsa','dsafsad','dsfasdf123123','+7 (213) 123-12-31','1231 231231'),(43,'ывфпафвпADsfd@#$$@','@$@$@$@@$#@$','$@$$@$#@$@$@$','$@$@$$24321423','+7 ( 45) 423-15-43','  34 523456');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contract`
--

DROP TABLE IF EXISTS `contract`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `contract` (
  `id` int NOT NULL AUTO_INCREMENT,
  `client` varchar(45) NOT NULL,
  `name_object` varchar(45) NOT NULL,
  `adress` varchar(45) NOT NULL,
  `type_object` text NOT NULL,
  `status` text NOT NULL,
  `type_security` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contract`
--

LOCK TABLES `contract` WRITE;
/*!40000 ALTER TABLE `contract` DISABLE KEYS */;
INSERT INTO `contract` VALUES (9,'Морозов Дмитрий Александрович','ГБПОУ \"ЗАМТ\"','г.Заволжье, пр.Мира, 18','Учебное заведение','Активен','Круглосуточная охрана'),(12,'Ловцов Игорь Иванович','МОУ \"Ковернинская средняя школа №1\"','го.Ковернино, ул.Школьная, д.17','Учебное заведение','Активен','По вызову'),(14,'Федоров Федор Федорович','Дворец спорта','г.Заволжье','Спортзал','Неактивен','По вызову'),(15,'Горбачёв Александр Артурович','Дворец Культуры','г.Заволжье','Культурный центр','Активен','Круглосуточная охрана'),(16,'ывфпафвпADsfd@#$$@ @$@$@$@@$#@$ $@$$@$#@$@$@$','QWWЫФВФЫВ','2ЦУЦУЙЦ','Жилой дом','Неактивен','Круглосуточная охрана');
/*!40000 ALTER TABLE `contract` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `incident`
--

DROP TABLE IF EXISTS `incident`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `incident` (
  `id` int NOT NULL AUTO_INCREMENT,
  `description` longtext NOT NULL,
  `status` varchar(45) NOT NULL,
  `date_incident` date DEFAULT NULL,
  `object` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `incident`
--

LOCK TABLES `incident` WRITE;
/*!40000 ALTER TABLE `incident` DISABLE KEYS */;
INSERT INTO `incident` VALUES (7,'Поступил сигнал о заложении в здании учебного корпуса взрывчатого вещества.','На исполнении',NULL,'ГБПОУ \"ЗАМТ\"'),(8,'qqqq','На исполнении',NULL,'QWWЫФВФЫВ');
/*!40000 ALTER TABLE `incident` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Сотрудник'),(2,'Дежурный'),(3,'Менеджер'),(4,'Администратор');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `security_object`
--

DROP TABLE IF EXISTS `security_object`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `security_object` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `address` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `security_object`
--

LOCK TABLES `security_object` WRITE;
/*!40000 ALTER TABLE `security_object` DISABLE KEYS */;
/*!40000 ALTER TABLE `security_object` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `type_object`
--

DROP TABLE IF EXISTS `type_object`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `type_object` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `type_object`
--

LOCK TABLES `type_object` WRITE;
/*!40000 ALTER TABLE `type_object` DISABLE KEYS */;
INSERT INTO `type_object` VALUES (1,'Парк'),(2,'Музей'),(3,'Жилой комплекс'),(4,'Государственное учреждение'),(5,'Торговый центр'),(6,'Спортзал'),(7,'Кинотеатр'),(8,'Больница'),(9,'Университет'),(10,'Школа'),(11,'Библиотека'),(12,'Ресторан'),(13,'Кафе'),(14,'Отель'),(15,'Автостанция'),(16,'Стадион'),(17,'Поликлиника'),(18,'Технический университет'),(19,'Торговая площадка'),(20,'Детский сад'),(21,'Церковь'),(22,'Мемориал'),(23,'Выставочный зал'),(24,'Научный центр'),(25,'Фитнес-центр'),(26,'Галерея'),(27,'Культурный центр'),(28,'Пляж'),(29,'Театр'),(30,'Жилой дом'),(31,'Учебное заведение');
/*!40000 ALTER TABLE `type_object` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `id` int NOT NULL AUTO_INCREMENT,
  `surname` varchar(45) NOT NULL,
  `name` varchar(45) NOT NULL,
  `patronymic` varchar(45) NOT NULL,
  `post` varchar(45) NOT NULL,
  `identification_card` varchar(11) NOT NULL,
  `login` text NOT NULL,
  `password` text NOT NULL,
  `role` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `role_idx` (`role`),
  CONSTRAINT `role` FOREIGN KEY (`role`) REFERENCES `roles` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=67 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Иванов','Иван','Иванович','Старший лейтенант','11345678','loginU1','password1',2),(2,'Петров','Петр','Петрович','Лейтенант','13456789','loginU2','password2',1),(3,'Сидоров','Сидор','Сидорович','Капитан','34567890','loginU3','password3',1),(4,'Попов','Поп','Попович','Полковник','45678901','loginU4','password4',1),(5,'Васильев','Василий','Васильевич','Майор','56789011','loginU5','password5',1),(6,'Кузнецов','Кузьма','Кузьмич','Подполковник','67890113','loginU6','password6',1),(7,'Семенов','Семён','Семенович','Старший лейтенант','78901134','loginU7','password7',1),(8,'Лебедев','Лебедь','Лебедевич','Лейтенант','89011345','loginU8','password8',1),(9,'Григорьев','Григорий','Григорьевич','Капитан','90113456','loginU9','password9',1),(10,'Романов','Роман','Романович','Полковник','11345678','loginU10','password10',1),(11,'Тихонов','Тихон','Тихонович','Майор','13456789','loginU11','password11',1),(12,'Фролов','Фрол','Фролович','Подполковник','34567890','loginU12','password12',1),(13,'Морозов','Мороз','Морозович','Старший лейтенант','45678901','loginU13','password13',3),(14,'Александров','Александр','Александрович','Лейтенант','56789011','loginU14','password14',1),(15,'Федоров','Фёдор','Федорович','Капитан','67890113','loginU15','password15',1),(16,'Зайцев','Зай','Зайцевич','Полковник','78901134','loginU16','password16',1),(17,'Волков','Волк','Волкович','Майор','89011345','loginU17','password17',1),(18,'Ковалев','Коваль','Ковалевич','Подполковник','90113456','loginU18','password18',1),(19,'Соловьев','Соловей','Соловьевич','Старший лейтенант','11345678','loginU19','password19',1),(20,'Николаев','Николай','Николаевич','Лейтенант','13456789','loginU20','password20',1),(21,'Ильин','Илья','Ильиевич','Капитан','34567890','loginU21','password21',2),(22,'Тимофеев','Тимофей','Тимофеевич','Полковник','45678901','loginU22','password22',1),(23,'Мельников','Мельник','Мельникович','Майор','56789011','loginU23','password23',1),(24,'Коротков','Короткий','Короткович','Подполковник','67890113','loginU24','password24',1),(25,'Беляев','Белый','Белыйевич','Старший лейтенант','78901134','loginU25','password25',1),(26,'Смирнов','Смирный','Смирнович','Лейтенант','89011345','loginU26','password26',1),(27,'Маслов','Масло','Маслович','Капитан','90113456','loginU27','password27',1),(28,'Кудряшов','Кудряша','Кудряшович','Полковник','11345678','loginU28','password28',1),(29,'Семенов','Семен','Семенович','Майор','13456789','loginU29','password29',3),(30,'Рябов','Ряб','Рябович','Подполковник','34567890','loginU30','password30',3),(31,'Кобзев','Кобза','Кобзевич','Старший лейтенант','45678901','loginU31','password31',1),(32,'Шевченко','Шевчик','Шевченкович','Лейтенант','56789011','loginU31','password31',1),(33,'Капустин','Капуста','Капустович','Капитан','67890113','loginU33','password33',1),(34,'Неверов','Невера','Неверович','Полковник','78901134','loginU34','password34',1),(35,'Лавров','Лавр','Лаврович','Майор','89011345','loginU35','password35',1),(36,'Алексеев','Алексей','Алексеевич','Подполковник','90113456','loginU36','password36',2),(37,'Борисов','Борис','Борисович','Старший лейтенант','11345678','loginU37','password37',1),(38,'Савельев','Савелий','Савельевич','Лейтенант','13456789','loginU38','password38',2),(39,'Марков','Марко','Маркович','Капитан','34567890','loginU39','password39',1),(40,'Шорин','Шора','Шоринович','Полковник','45678901','loginU40','password40',1),(41,'Филатов','Филат','Филатович','Майор','56789011','loginU41','password41',1),(42,'Куприянов','Куприян','Куприянович','Подполковник','67890113','loginU41','password41',1),(43,'Сычев','Сыч','Сычевич','Старший лейтенант','78901134','loginU43','password43',1),(44,'Тетерев','Тетерево','Тетеревич','Лейтенант','89011345','loginU44','password44',1),(45,'Константинов','Константин','Константинович','Капитан','90113456','loginU45','password45',1),(46,'Нечаев','Нечай','Нечаевич','Полковник','11345678','loginU46','password46',1),(47,'Степанов','Степан','Степанович','Майор','13456789','loginU47','password47',2),(48,'Воробьев','Воробей','Воробьевич','Подполковник','34567890','loginU48','password48',1),(49,'Гончаров','Гонка','Гончарович','Старший лейтенант','45678901','loginU49','password49',2),(50,'Степанова','Степан','Степанович','Лейтенант','56789011','loginU50','password50',1),(51,'Беляков','Вадим','Александрович','Лейтенант','11110000','admin','admin',4),(52,'Иванов','Илья','Александрович','Полковник','77710202','loginUUV2qcT','sl5cLQAr',4),(53,'Мокрушин','Артем','Вячеславович','Майор','2028888','loginUXa33o9','BgOUa71r',2),(54,'Голубев','Вадим','Александрович','Капитан','1321235','loginUtgdDU9','WLUP6Y83',3),(55,'Кошелев','Антон','Алексеевич','Лейтенант','12 312312','loginU26EPg6','1vHHWGT0',1),(56,'User','User','','Младший лейтенант','00 000000','usr','usr',1),(57,'Duty','Duty','','Лейтенант','11 111111','duty','duty',2),(58,'manager','manager','','Старший лейтенант','22 222222','manag','manag',3),(59,'Пулькин','Данил','','Младший лейтенант','12 332135','loginUCcPEdl','bTgosQC6',1),(63,'вываыа','аывфаывафыв','','Лейтенант','13 456789','loginUiALqiP','vrep2XYO',1),(64,'выаывфаы','ываывфаывф','','Лейтенант','13 456789','loginUPLAvvJ','g3cFgJfe',1),(65,'dsfasd','sdafasdfs','','Младший лейтенант','13 456789','loginUhDrN8S','i5gdgaQU',1),(66,'DsaSda','FDSfds','Fds','Лейтенант','11 231231','loginUlhlMgC','dYcD6E5d',2);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-16 13:36:41
