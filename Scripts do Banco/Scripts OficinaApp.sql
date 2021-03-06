USE [master]
GO
/****** Object:  Database [OficinaApp]    Script Date: 20/07/2021 08:28:47 ******/
CREATE DATABASE [OficinaApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OficinaApp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.ORNELASTEC\MSSQL\DATA\OficinaApp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OficinaApp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.ORNELASTEC\MSSQL\DATA\OficinaApp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [OficinaApp] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OficinaApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OficinaApp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OficinaApp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OficinaApp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OficinaApp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OficinaApp] SET ARITHABORT OFF 
GO
ALTER DATABASE [OficinaApp] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [OficinaApp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OficinaApp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OficinaApp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OficinaApp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OficinaApp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OficinaApp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OficinaApp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OficinaApp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OficinaApp] SET  ENABLE_BROKER 
GO
ALTER DATABASE [OficinaApp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OficinaApp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OficinaApp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OficinaApp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OficinaApp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OficinaApp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OficinaApp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OficinaApp] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [OficinaApp] SET  MULTI_USER 
GO
ALTER DATABASE [OficinaApp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OficinaApp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OficinaApp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OficinaApp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OficinaApp] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OficinaApp] SET QUERY_STORE = OFF
GO
USE [OficinaApp]
GO
/****** Object:  User [OficinaUser]    Script Date: 20/07/2021 08:28:48 ******/
CREATE USER [OficinaUser] FOR LOGIN [OficinaUser] WITH DEFAULT_SCHEMA=[db_datareader]
GO
ALTER ROLE [db_datareader] ADD MEMBER [OficinaUser]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [OficinaUser]
GO
/****** Object:  Table [dbo].[Aparelhos_Cores]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aparelhos_Cores](
	[IdAparelhos_Cores] [int] IDENTITY(1,1) NOT NULL,
	[Id_Aparelho] [int] NOT NULL,
	[Id_Cor] [int] NOT NULL,
 CONSTRAINT [PK_AparelhosCores] PRIMARY KEY CLUSTERED 
(
	[IdAparelhos_Cores] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipos]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipos](
	[IdTipo] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tipos] PRIMARY KEY CLUSTERED 
(
	[IdTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[IdMarca] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED 
(
	[IdMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modelos]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modelos](
	[IdModelo] [int] IDENTITY(1,1) NOT NULL,
	[Modelo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Modelos] PRIMARY KEY CLUSTERED 
(
	[IdModelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estados](
	[IdEstado] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Estados] PRIMARY KEY CLUSTERED 
(
	[IdEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cores]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cores](
	[IdCor] [int] IDENTITY(1,1) NOT NULL,
	[Cor] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Cores] PRIMARY KEY CLUSTERED 
(
	[IdCor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Telefones]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefones](
	[IdTelefone] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cliente] [int] NULL,
	[Numero] [varchar](50) NOT NULL,
	[Whats] [bit] NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Telefones] PRIMARY KEY CLUSTERED 
(
	[IdTelefone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[DataCad] [date] NOT NULL,
	[Cpf] [varchar](50) NOT NULL,
	[Sexo] [char](1) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aparelhos]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aparelhos](
	[IdAparelho] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[Id_Tipo] [int] NOT NULL,
	[Id_Marca] [int] NOT NULL,
	[Id_Modelo] [int] NOT NULL,
	[Id_Estado] [int] NOT NULL,
	[Id_Tecnico] [int] NULL,
	[Entrada] [datetime] NOT NULL,
	[Saida] [datetime] NULL,
	[Problema] [varchar](100) NOT NULL,
	[Observacao] [varchar](300) NULL,
	[Orcamento] [varchar](300) NULL,
	[MaoDeObra] [money] NULL,
	[Urgencia] [bit] NOT NULL,
	[Revisao] [bit] NOT NULL,
	[DataModificacao] [datetime] NULL,
 CONSTRAINT [PK_Aparelhos] PRIMARY KEY CLUSTERED 
(
	[IdAparelho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_GridPrincipal]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_GridPrincipal]
AS
SELECT        A.IdAparelho, C.IdCliente, A.Entrada, C.Nome, C.Cpf, T.Numero, TI.Tipo, MA.Marca, MO.Modelo, A.Problema, STRING_AGG(CONVERT(NVARCHAR(MAX), CO.Cor), ' / ') AS Cor, ES.Estado, A.Saida, A.Urgencia, A.Revisao, 
                         A.DataModificacao
FROM            dbo.Aparelhos AS A LEFT OUTER JOIN
                         dbo.Aparelhos_Cores AS APC ON A.IdAparelho = APC.Id_Aparelho LEFT OUTER JOIN
                         dbo.Cores AS CO ON CO.IdCor = APC.Id_Cor LEFT OUTER JOIN
                         dbo.Clientes AS C ON C.IdCliente = A.Id_Cliente LEFT OUTER JOIN
                         dbo.Tipos AS TI ON A.Id_Tipo = TI.IdTipo LEFT OUTER JOIN
                         dbo.Marcas AS MA ON A.Id_Marca = MA.IdMarca LEFT OUTER JOIN
                         dbo.Modelos AS MO ON A.Id_Modelo = MO.IdModelo LEFT OUTER JOIN
                         dbo.Estados AS ES ON A.Id_Estado = ES.IdEstado LEFT OUTER JOIN
                             (SELECT        MIN(Numero) AS Numero, Id_Cliente
                               FROM            dbo.Telefones
                               GROUP BY Id_Cliente) AS T ON C.IdCliente = T.Id_Cliente
GROUP BY A.IdAparelho, A.Entrada, A.Problema, A.Saida, C.Nome, C.IdCliente, T.Numero, ES.Estado, TI.Tipo, MA.Marca, MO.Modelo, A.Urgencia, A.Revisao, C.Cpf, A.DataModificacao
GO
/****** Object:  Table [dbo].[Tecnicos]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tecnicos](
	[IdTecnico] [int] IDENTITY(1,1) NOT NULL,
	[NomeTecnico] [varchar](100) NOT NULL,
	[Numero] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tecnico] PRIMARY KEY CLUSTERED 
(
	[IdTecnico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Vw_AparelhoInfo]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vw_AparelhoInfo]
AS
SELECT        A.IdAparelho, C.IdCliente, C.Nome, C.Cpf, A.Entrada, A.Saida, A.Problema, A.Observacao, A.Orcamento, A.MaoDeObra, A.Urgencia, A.Revisao, T.Tipo, Ma.Marca, Mo.Modelo, Es.Estado, STRING_AGG(CONVERT(NVARCHAR(MAX), 
                         CO.Cor), ' / ') AS Cor, Te.NomeTecnico, Te.IdTecnico
FROM            dbo.Aparelhos AS A LEFT OUTER JOIN
                         dbo.Tipos AS T ON A.Id_Tipo = T.IdTipo LEFT OUTER JOIN
                         dbo.Marcas AS Ma ON A.Id_Marca = Ma.IdMarca LEFT OUTER JOIN
                         dbo.Modelos AS Mo ON A.Id_Modelo = Mo.IdModelo LEFT OUTER JOIN
                         dbo.Estados AS Es ON A.Id_Estado = Es.IdEstado LEFT OUTER JOIN
                         dbo.Tecnicos AS Te ON A.Id_Tecnico = Te.IdTecnico LEFT OUTER JOIN
                         dbo.Clientes AS C ON A.Id_Cliente = C.IdCliente LEFT OUTER JOIN
                         dbo.Aparelhos_Cores AS APC ON A.IdAparelho = APC.Id_Aparelho LEFT OUTER JOIN
                         dbo.Cores AS CO ON CO.IdCor = APC.Id_Cor
GROUP BY A.IdAparelho, C.IdCliente, C.Nome, C.Cpf, A.Entrada, A.Saida, A.Problema, A.Observacao, A.Orcamento, A.MaoDeObra, A.Urgencia, A.Revisao, T.Tipo, Ma.Marca, Mo.Modelo, Es.Estado, Te.NomeTecnico, Te.IdTecnico, C.Cpf
GO
/****** Object:  View [dbo].[Vw_AparelhoCores]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[Vw_AparelhoCores]
as
Select Id_Aparelho ,IdAparelhos_Cores, Id_Cor as IdCor, Cor  from Aparelhos_Cores
left Join Cores on Id_Cor = IdCor
GO
/****** Object:  Table [dbo].[Contatos]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contatos](
	[IdContato] [int] IDENTITY(1,1) NOT NULL,
	[Id_Aparelho] [int] NOT NULL,
	[Id_Tecnico] [int] NOT NULL,
	[Id_Telefone] [int] NULL,
	[Id_Estado] [int] NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
	[StatusLig] [varchar](50) NULL,
	[DataContato] [datetime] NOT NULL,
	[Dialogo] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Contato] PRIMARY KEY CLUSTERED 
(
	[IdContato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Vw_Contato]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vw_Contato]
AS
SELECT        C.IdContato, C.Id_Aparelho, C.DataContato, C.Dialogo, C.Tipo, C.StatusLig, Te.NomeTecnico, T.Numero, E.Estado
FROM            dbo.Contatos AS C LEFT OUTER JOIN
                         dbo.Tecnicos AS Te ON C.Id_Tecnico = Te.IdTecnico LEFT OUTER JOIN
                         dbo.Telefones AS T ON C.Id_Telefone = T.IdTelefone LEFT OUTER JOIN
                         dbo.Estados AS E ON C.Id_Estado = E.IdEstado
GO
/****** Object:  Table [dbo].[Itens]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Itens](
	[IdItem] [int] IDENTITY(1,1) NOT NULL,
	[Id_Aparelho] [int] NOT NULL,
	[Id_Produto] [int] NOT NULL,
	[Item] [varchar](100) NOT NULL,
	[Valor] [money] NOT NULL,
	[Quantidade] [int] NOT NULL,
 CONSTRAINT [PK_Itens] PRIMARY KEY CLUSTERED 
(
	[IdItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pagamentos_Aparelhos]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagamentos_Aparelhos](
	[IdPagamentoAparelho] [int] IDENTITY(1,1) NOT NULL,
	[Id_Aparelho] [int] NOT NULL,
	[Id_Pagamento] [int] NOT NULL,
 CONSTRAINT [PK_PagamentoAparelho] PRIMARY KEY CLUSTERED 
(
	[IdPagamentoAparelho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Aparelhos]  WITH CHECK ADD  CONSTRAINT [FK_Aparelhos_Clientes] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[Aparelhos] CHECK CONSTRAINT [FK_Aparelhos_Clientes]
GO
ALTER TABLE [dbo].[Aparelhos]  WITH CHECK ADD  CONSTRAINT [FK_Aparelhos_Estados] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[Estados] ([IdEstado])
GO
ALTER TABLE [dbo].[Aparelhos] CHECK CONSTRAINT [FK_Aparelhos_Estados]
GO
ALTER TABLE [dbo].[Aparelhos]  WITH CHECK ADD  CONSTRAINT [FK_Aparelhos_Marcas] FOREIGN KEY([Id_Marca])
REFERENCES [dbo].[Marcas] ([IdMarca])
GO
ALTER TABLE [dbo].[Aparelhos] CHECK CONSTRAINT [FK_Aparelhos_Marcas]
GO
ALTER TABLE [dbo].[Aparelhos]  WITH CHECK ADD  CONSTRAINT [FK_Aparelhos_Modelos] FOREIGN KEY([Id_Modelo])
REFERENCES [dbo].[Modelos] ([IdModelo])
GO
ALTER TABLE [dbo].[Aparelhos] CHECK CONSTRAINT [FK_Aparelhos_Modelos]
GO
ALTER TABLE [dbo].[Aparelhos]  WITH CHECK ADD  CONSTRAINT [FK_Aparelhos_Tecnicos] FOREIGN KEY([Id_Tecnico])
REFERENCES [dbo].[Tecnicos] ([IdTecnico])
GO
ALTER TABLE [dbo].[Aparelhos] CHECK CONSTRAINT [FK_Aparelhos_Tecnicos]
GO
ALTER TABLE [dbo].[Aparelhos]  WITH CHECK ADD  CONSTRAINT [FK_Aparelhos_Tipos] FOREIGN KEY([Id_Tipo])
REFERENCES [dbo].[Tipos] ([IdTipo])
GO
ALTER TABLE [dbo].[Aparelhos] CHECK CONSTRAINT [FK_Aparelhos_Tipos]
GO
ALTER TABLE [dbo].[Aparelhos_Cores]  WITH CHECK ADD  CONSTRAINT [FK_AparelhosCores_Aparelhos] FOREIGN KEY([Id_Aparelho])
REFERENCES [dbo].[Aparelhos] ([IdAparelho])
GO
ALTER TABLE [dbo].[Aparelhos_Cores] CHECK CONSTRAINT [FK_AparelhosCores_Aparelhos]
GO
ALTER TABLE [dbo].[Aparelhos_Cores]  WITH CHECK ADD  CONSTRAINT [FK_AparelhosCores_Cores] FOREIGN KEY([Id_Cor])
REFERENCES [dbo].[Cores] ([IdCor])
GO
ALTER TABLE [dbo].[Aparelhos_Cores] CHECK CONSTRAINT [FK_AparelhosCores_Cores]
GO
ALTER TABLE [dbo].[Contatos]  WITH CHECK ADD  CONSTRAINT [FK_Contatos_Estados] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[Estados] ([IdEstado])
GO
ALTER TABLE [dbo].[Contatos] CHECK CONSTRAINT [FK_Contatos_Estados]
GO
ALTER TABLE [dbo].[Contatos]  WITH CHECK ADD  CONSTRAINT [FK_Contatos_Tecnicos] FOREIGN KEY([Id_Tecnico])
REFERENCES [dbo].[Tecnicos] ([IdTecnico])
GO
ALTER TABLE [dbo].[Contatos] CHECK CONSTRAINT [FK_Contatos_Tecnicos]
GO
ALTER TABLE [dbo].[Contatos]  WITH CHECK ADD  CONSTRAINT [FK_Contatos_Telefones] FOREIGN KEY([Id_Telefone])
REFERENCES [dbo].[Telefones] ([IdTelefone])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Contatos] CHECK CONSTRAINT [FK_Contatos_Telefones]
GO
ALTER TABLE [dbo].[Itens]  WITH CHECK ADD  CONSTRAINT [FK_Itens_Aparelhos] FOREIGN KEY([Id_Aparelho])
REFERENCES [dbo].[Aparelhos] ([IdAparelho])
GO
ALTER TABLE [dbo].[Itens] CHECK CONSTRAINT [FK_Itens_Aparelhos]
GO
ALTER TABLE [dbo].[Pagamentos_Aparelhos]  WITH CHECK ADD  CONSTRAINT [FK_PagamentosAparelhos_Aparelhos] FOREIGN KEY([Id_Aparelho])
REFERENCES [dbo].[Aparelhos] ([IdAparelho])
GO
ALTER TABLE [dbo].[Pagamentos_Aparelhos] CHECK CONSTRAINT [FK_PagamentosAparelhos_Aparelhos]
GO
ALTER TABLE [dbo].[Telefones]  WITH CHECK ADD  CONSTRAINT [FK_Telefones_Clientes] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[Telefones] CHECK CONSTRAINT [FK_Telefones_Clientes]
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertAparelhos]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_InsertAparelhos]
@Id_Cliente int,
@Id_Tipo int,
@Id_Marca int,
@Id_Modelo int,
@Id_Estado int,
@Entrada DateTime,
@Problema varchar(100),
@Observacao varchar(100),
@Urgencia bit,
@Revisao bit
as


Insert into Aparelhos values(@Id_Cliente, @Id_Tipo, @Id_Marca, @Id_Modelo, 
@Id_Estado, null, @Entrada, null, @Problema, @Observacao, null, null, @Urgencia, @Revisao, null)

Select @@IDENTITY as idAp



GO
/****** Object:  StoredProcedure [dbo].[SP_InsertCliente]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_InsertCliente]
@Nome varchar(100),
@DataCad Date,
@Cpf varchar(50),
@Sexo char
as
Insert into Clientes Values(@nome, @DataCad, @Cpf, @Sexo)

Select @@IDENTITY as IdCliente
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertMarca]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_InsertMarca]
@Marca varchar(100)
as
Insert Into Marcas Values(@Marca)

Select @@IDENTITY as idMarca
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertModelo]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_InsertModelo]
@Modelo varchar(100)
as
Insert Into Modelos Values(@Modelo)

Select @@IDENTITY as idModelo
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertTipo]    Script Date: 20/07/2021 08:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_InsertTipo]
@Tipo varchar(100)
as
Insert Into Tipos Values(@Tipo)

Select @@IDENTITY as idTipo
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "A"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "T"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 234
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ma"
            Begin Extent = 
               Top = 234
               Left = 38
               Bottom = 330
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mo"
            Begin Extent = 
               Top = 330
               Left = 38
               Bottom = 426
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Es"
            Begin Extent = 
               Top = 426
               Left = 38
               Bottom = 539
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Te"
            Begin Extent = 
               Top = 540
               Left = 38
               Bottom = 653
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "C"
            Begin Extent = 
               Top = 654
               Left = 38
               Bottom = 784
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_AparelhoInfo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
         Begin Table = "APC"
            Begin Extent = 
               Top = 6
               Left = 272
               Bottom = 119
               Right = 468
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CO"
            Begin Extent = 
               Top = 6
               Left = 506
               Bottom = 102
               Right = 702
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_AparelhoInfo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_AparelhoInfo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "C"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Te"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 251
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "T"
            Begin Extent = 
               Top = 252
               Left = 38
               Bottom = 382
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "E"
            Begin Extent = 
               Top = 384
               Left = 38
               Bottom = 497
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_Contato'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_Contato'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[25] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "A"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "APC"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 251
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CO"
            Begin Extent = 
               Top = 252
               Left = 38
               Bottom = 348
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "C"
            Begin Extent = 
               Top = 348
               Left = 38
               Bottom = 478
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TI"
            Begin Extent = 
               Top = 480
               Left = 38
               Bottom = 576
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MA"
            Begin Extent = 
               Top = 576
               Left = 38
               Bottom = 672
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MO"
            Begin Extent = 
               Top = 672
               Left = 38
               Bottom = 768
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 0
         E' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_GridPrincipal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'nd
         Begin Table = "ES"
            Begin Extent = 
               Top = 768
               Left = 38
               Bottom = 881
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "T"
            Begin Extent = 
               Top = 6
               Left = 288
               Bottom = 102
               Right = 500
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_GridPrincipal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_GridPrincipal'
GO
USE [master]
GO
ALTER DATABASE [OficinaApp] SET  READ_WRITE 
GO
