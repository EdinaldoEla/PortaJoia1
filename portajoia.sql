-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 26-Maio-2022 às 14:25
-- Versão do servidor: 10.4.22-MariaDB
-- versão do PHP: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `portajoia`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

CREATE TABLE `produto` (
  `IdProduto` int(11) NOT NULL,
  `NomeProduto` varchar(150) NOT NULL,
  `Unidade` varchar(20) NOT NULL,
  `Quantidade` int(11) NOT NULL,
  `PrecoProduto` double(9,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `produto`
--

INSERT INTO `produto` (`IdProduto`, `NomeProduto`, `Unidade`, `Quantidade`, `PrecoProduto`) VALUES
(2, 'SHAMPOO', 'FRASCO', 25, 85.50),
(3, 'CREME PARA CABELO', 'TUBO', 134, 42.80),
(4, 'CREME HIDRATANTE', 'FRASCO', 35, 39.95),
(5, 'ESMALTE INCOLOR', 'FRASCO', 95, 8.30),
(6, 'LIXAS PARA UNHAS', 'UMA', 282, 2.50),
(7, 'REMOVEDOR DE ESMALTES', 'FRASCO', 55, 8.00),
(8, 'ALGODÃO', 'PACOTE', 138, 4.52),
(23, 'Girafa', 'um', 8, 78.40),
(24, 'NOVO PROD', 'UM', 3, 35.50);

-- --------------------------------------------------------

--
-- Estrutura da tabela `servico`
--

CREATE TABLE `servico` (
  `IdServico` int(11) NOT NULL,
  `NomeServico` varchar(150) NOT NULL,
  `PrecoServico` double(9,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `servico`
--

INSERT INTO `servico` (`IdServico`, `NomeServico`, `PrecoServico`) VALUES
(2, 'CORTE DE CABELO', 35.00),
(3, 'CRONOGRAMA CAPILAR', 48.00),
(4, 'ESCOVA', 39.00),
(5, 'PROGRESSIVA', 120.00),
(6, 'SPA DOS PÉS', 45.95),
(7, 'DEPILAÇÃO', 85.00),
(14, 'Teste Serviço2', 256.55),
(15, 'NOVO SERVIÇO', 23.00);

-- --------------------------------------------------------

--
-- Estrutura da tabela `trabalheconosco`
--

CREATE TABLE `trabalheconosco` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(150) NOT NULL,
  `DataNascimento` datetime NOT NULL,
  `Telefone` varchar(20) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Experiencia` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `trabalheconosco`
--

INSERT INTO `trabalheconosco` (`Id`, `Nome`, `DataNascimento`, `Telefone`, `Email`, `Experiencia`) VALUES
(1, 'paulo', '1982-02-12 00:00:00', '80809890889', 'paulo@gmail.com', 'teste3'),
(2, 'MARIA', '2022-02-06 00:00:00', '8908908908', 'maria@hotmail.com', 'dois'),
(5, 'solange', '2022-02-04 00:00:00', '890890809', 'jljlkjl', 'jljljljlk'),
(7, 'VERONICA', '1959-04-05 00:00:00', '048908908', '1985', 'REGULAR'),
(8, 'catarina', '1987-05-10 00:00:00', '09890890', 'catarina@gmail.com', 'teste'),
(10, 'catarina2', '1987-07-10 00:00:00', '890890890', 'catarina@gmail.com', 'teste'),
(12, 'alfredo', '1999-07-10 00:00:00', '98898989', 'alfredo@gmai.com', 'teste alfredo'),
(13, 'FULANO DE TAL', '1986-04-12 00:00:00', '898795', 'TESTE@GMAIL', 'MUITA'),
(14, 'FULANO DE TAL', '1986-04-12 00:00:00', '898795', 'TESTE@GMAIL', 'MUITA'),
(15, 'CICRANO', '1987-12-04 00:00:00', '789798789', 'TESTE@GMAIL', 'POUCA'),
(16, 'NOVO COLAB', '1963-04-21 00:00:00', '789798', 'edinaldo@gmail', 'pouca'),
(17, 'catarina', '2022-05-25 09:13:00', '9798798', 'teste', 'pouca'),
(18, 'catarina', '2022-05-25 09:13:00', '9798798', 'teste', 'pouca'),
(19, 'catarina', '2022-05-25 09:13:00', '9798798', 'teste', 'pouca');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(150) DEFAULT NULL,
  `Login` varchar(150) NOT NULL,
  `Senha` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`Id`, `Nome`, `Login`, `Senha`) VALUES
(1, 'EDINALDO', 'edinaldo', '12345'),
(2, 'MARIA', 'maria', '123456'),
(3, 'JOSÉ', 'jose', '1234'),
(4, 'Tobi2', 'tobi', '1234');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`IdProduto`);

--
-- Índices para tabela `servico`
--
ALTER TABLE `servico`
  ADD PRIMARY KEY (`IdServico`);

--
-- Índices para tabela `trabalheconosco`
--
ALTER TABLE `trabalheconosco`
  ADD PRIMARY KEY (`Id`);

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `produto`
--
ALTER TABLE `produto`
  MODIFY `IdProduto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT de tabela `servico`
--
ALTER TABLE `servico`
  MODIFY `IdServico` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de tabela `trabalheconosco`
--
ALTER TABLE `trabalheconosco`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
