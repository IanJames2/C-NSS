CREATE TABLE `Job` (
  `id` int PRIMARY KEY,
  `averageIncome` int,
  `educationRequired` varcharacter,
  `userId` int,
  `description` varcharacter,
  `company` varcharacter,
  `imageUrl` varcharacter
);

CREATE TABLE `User` (
  `id` int PRIMARY KEY,
  `name` varcharacter,
  `address` varcharacter,
  `cityId` int,
  `phone` int,
  `email` varcharacter
);

CREATE TABLE `City` (
  `id` int PRIMARY KEY,
  `name` varcharacter,
  `state` varcharacter,
  `remote` boolean
);

CREATE TABLE `CEO` (
  `id` int PRIMARY KEY,
  `name` varcharacter,
  `imageUrl` varcharacter,
  `cityId` int
);

CREATE TABLE `Archive` (
  `id` int PRIMARY KEY,
  `date` date,
  `duration` int,
  `CEOId` int,
  `jobId` int
);

ALTER TABLE `City` ADD FOREIGN KEY (`id`) REFERENCES `CEO` (`cityId`);

ALTER TABLE `Job` ADD FOREIGN KEY (`userId`) REFERENCES `User` (`id`);

ALTER TABLE `Job` ADD FOREIGN KEY (`id`) REFERENCES `Archive` (`jobId`);

ALTER TABLE `CEO` ADD FOREIGN KEY (`id`) REFERENCES `Archive` (`CEOId`);
