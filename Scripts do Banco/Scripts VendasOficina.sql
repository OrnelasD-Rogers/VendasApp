USE [master]
GO
/****** Object:  Database [VendasOficina]    Script Date: 20/07/2021 08:29:27 ******/
CREATE DATABASE [VendasOficina]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VendasOficina', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.ORNELASTEC\MSSQL\DATA\VendasOficina.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VendasOficina_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.ORNELASTEC\MSSQL\DATA\VendasOficina_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [VendasOficina] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VendasOficina].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VendasOficina] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VendasOficina] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VendasOficina] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VendasOficina] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VendasOficina] SET ARITHABORT OFF 
GO
ALTER DATABASE [VendasOficina] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [VendasOficina] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VendasOficina] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VendasOficina] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VendasOficina] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VendasOficina] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VendasOficina] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VendasOficina] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VendasOficina] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VendasOficina] SET  ENABLE_BROKER 
GO
ALTER DATABASE [VendasOficina] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VendasOficina] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VendasOficina] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VendasOficina] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VendasOficina] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VendasOficina] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VendasOficina] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VendasOficina] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VendasOficina] SET  MULTI_USER 
GO
ALTER DATABASE [VendasOficina] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VendasOficina] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VendasOficina] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VendasOficina] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VendasOficina] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VendasOficina] SET QUERY_STORE = OFF
GO
USE [VendasOficina]
GO
/****** Object:  User [OficinaUser]    Script Date: 20/07/2021 08:29:27 ******/
CREATE USER [OficinaUser] FOR LOGIN [OficinaUser] WITH DEFAULT_SCHEMA=[db_datareader]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [OficinaUser]
GO
ALTER ROLE [db_datareader] ADD MEMBER [OficinaUser]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [OficinaUser]
GO
/****** Object:  Table [dbo].[Compras_Produtos]    Script Date: 20/07/2021 08:29:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras_Produtos](
	[IdCompra_Produto] [int] IDENTITY(1,1) NOT NULL,
	[Id_Compra] [int] NULL,
	[Id_Produto] [int] NULL,
	[ValorUnidade] [int] NULL,
	[Quantidade] [int] NULL,
	[SubTotal] [money] NULL,
 CONSTRAINT [PK_ComprasProdutos] PRIMARY KEY CLUSTERED 
(
	[IdCompra_Produto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produtos]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produtos](
	[IdProduto] [int] IDENTITY(1,1) NOT NULL,
	[Id_Categoria] [int] NULL,
	[Id_Tipo] [int] NULL,
	[Id_Marca] [int] NULL,
	[Id_Modelo] [int] NULL,
	[Produto] [varchar](100) NULL,
	[Descricao] [varchar](100) NULL,
	[ValorCompra] [money] NULL,
	[ValorVenda] [money] NULL,
	[Estoque] [int] NULL,
	[Estado] [bit] NULL,
	[EstoqueMin] [int] NULL,
 CONSTRAINT [PK_Produtos] PRIMARY KEY CLUSTERED 
(
	[IdProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_ProdutosCompra]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_ProdutosCompra]
AS
SELECT        CP.Id_Compra, CP.Id_Produto, P.Produto, CP.ValorUnidade, CP.Quantidade, CP.SubTotal
FROM            dbo.Compras_Produtos AS CP LEFT OUTER JOIN
                         dbo.Produtos AS P ON CP.Id_Produto = P.IdProduto
GO
/****** Object:  Table [dbo].[Fornecedores]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedores](
	[IdFornecedor] [int] IDENTITY(1,1) NOT NULL,
	[Fornecedor] [varchar](100) NULL,
	[Telefone] [varchar](50) NULL,
	[WhatsApp] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
 CONSTRAINT [PK_Fornecedores] PRIMARY KEY CLUSTERED 
(
	[IdFornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[IdCompra] [int] IDENTITY(1,1) NOT NULL,
	[Id_Fornecedor] [int] NULL,
	[DataCompra] [date] NULL,
	[Compra] [varchar](100) NULL,
	[ValorTotal] [money] NULL,
	[ValorFrete] [money] NULL,
	[NotaFiscal] [varchar](100) NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[IdCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_Compras]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[VW_Compras]
as
Select IdCompra, DataCompra, Compra, NotaFiscal, ValorFrete, ValorTotal, Fornecedor from Compras
inner join Fornecedores
on IdFornecedor = Id_Fornecedor
GO
/****** Object:  Table [dbo].[Modelos]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modelos](
	[IdModelo] [int] IDENTITY(1,1) NOT NULL,
	[Modelo] [varchar](100) NULL,
 CONSTRAINT [PK_Modelos] PRIMARY KEY CLUSTERED 
(
	[IdModelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[IdMarca] [int] IDENTITY(1,1) NOT NULL,
	[Id_Modelo] [int] NULL,
	[Marca] [varchar](100) NULL,
 CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED 
(
	[IdMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipos]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipos](
	[IdTipo] [int] IDENTITY(1,1) NOT NULL,
	[Id_Marca] [int] NULL,
	[Tipo] [varchar](100) NULL,
 CONSTRAINT [PK_Tipos] PRIMARY KEY CLUSTERED 
(
	[IdTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_ProdutosString]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create View [dbo].[VW_ProdutosString]
as
SELECT IdProduto, (Produto + ' para ' + Ti.Tipo+ ' ' + Ma.Marca + ', Modelo: ' + Mo.Modelo) as Produto, Descricao, ValorCompra, ValorVenda, Estoque, Estado FROM Produtos Pr
inner join Tipos Ti
on Ti.IdTipo = Pr.Id_Tipo
inner join Marcas Ma
on Ma.IdMarca = Pr.Id_Marca
inner join Modelos Mo
on Mo.IdModelo = Pr.Id_Modelo
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Categoria] [varchar](100) NULL,
 CONSTRAINT [PK_Categrorias] PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_ProdutosGrid]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_ProdutosGrid]
AS
SELECT        Pr.IdProduto, Pr.Produto, Ca.Categoria, Ti.Tipo, Ma.Marca, Mo.Modelo, Pr.Descricao, Pr.ValorCompra, Pr.ValorVenda, Pr.Estoque, Pr.EstoqueMin, Pr.Estado
FROM            dbo.Produtos AS Pr LEFT OUTER JOIN
                         dbo.Categorias AS Ca ON Pr.Id_Categoria = Ca.IdCategoria LEFT OUTER JOIN
                         dbo.Tipos AS Ti ON Pr.Id_Tipo = Ti.IdTipo LEFT OUTER JOIN
                         dbo.Marcas AS Ma ON Pr.Id_Marca = Ma.IdMarca LEFT OUTER JOIN
                         dbo.Modelos AS Mo ON Pr.Id_Modelo = Mo.IdModelo
GO
/****** Object:  Table [dbo].[Vendas]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendas](
	[IdVenda] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cliente] [int] NULL,
	[Id_Vendedor] [int] NULL,
	[DataVenda] [datetime] NULL,
	[TipoComprovante] [varchar](100) NULL,
	[NumeroComprovante] [varchar](100) NULL,
	[Total] [money] NULL,
	[TotalPago] [money] NULL,
	[TipoVenda] [varchar](100) NULL,
 CONSTRAINT [PK_Vendas] PRIMARY KEY CLUSTERED 
(
	[IdVenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](200) NOT NULL,
	[Sexo] [char](1) NOT NULL,
	[Cpf] [varchar](50) NULL,
	[Email] [varchar](200) NULL,
	[Telefone] [varchar](20) NOT NULL,
	[WhatsApp] [varchar](20) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vendedores]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendedores](
	[IdVendedor] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](200) NULL,
	[Email] [varchar](200) NULL,
	[Telefone] [varchar](20) NULL,
	[WhatsApp] [varchar](20) NULL,
	[Sexo] [char](1) NULL,
 CONSTRAINT [PK_Vendedores] PRIMARY KEY CLUSTERED 
(
	[IdVendedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_GridVendas]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create View [dbo].[VW_GridVendas]
as
Select Ve.IdVenda, Ves.IdVendedor, Cl.IdCliente, Cl.Nome as NomeCli, Ves.Nome as NomeVendedor, Ve.DataVenda, Ve.TipoComprovante, Ve.NumeroComprovante, Ve.Total, Ve.TipoVenda From Vendas Ve
left join Clientes Cl
on Ve.Id_Cliente = Cl.IdCliente
left join Vendedores Ves
on Ve.Id_Vendedor = Ves.IdVendedor
GO
/****** Object:  Table [dbo].[Produtos_Vendas]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produtos_Vendas](
	[IdProduto_Venda] [int] IDENTITY(1,1) NOT NULL,
	[Id_Venda] [int] NULL,
	[Id_Produto] [int] NULL,
	[ValorVenda] [money] NULL,
	[Quantidade] [int] NULL,
	[SubTotal] [money] NULL,
 CONSTRAINT [PK_Produtos_Vendas] PRIMARY KEY CLUSTERED 
(
	[IdProduto_Venda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_ProdutosVenda]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_ProdutosVenda]
AS
SELECT        Pv.IdProduto_Venda, Pv.Id_Produto, Pv.Id_Venda, Pr.Produto, Pv.ValorVenda, Pv.Quantidade, Pv.SubTotal
FROM            dbo.Produtos_Vendas AS Pv LEFT OUTER JOIN
                         dbo.Produtos AS Pr ON Pv.Id_Produto = Pr.IdProduto
GO
/****** Object:  Table [dbo].[Pagamentos]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagamentos](
	[IdPagamento] [int] IDENTITY(1,1) NOT NULL,
	[DataPag] [datetime] NOT NULL,
	[TipoPag] [varchar](100) NOT NULL,
	[Valor] [money] NOT NULL,
	[Categoria] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Pagamentos] PRIMARY KEY CLUSTERED 
(
	[IdPagamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vendas_Pagamentos]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendas_Pagamentos](
	[IdVenda_Pagamento] [int] IDENTITY(1,1) NOT NULL,
	[Id_Venda] [int] NULL,
	[Id_Pagamento] [int] NULL,
 CONSTRAINT [PK_VendasPagamentos] PRIMARY KEY CLUSTERED 
(
	[IdVenda_Pagamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Fornecedores] FOREIGN KEY([Id_Fornecedor])
REFERENCES [dbo].[Fornecedores] ([IdFornecedor])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Fornecedores]
GO
ALTER TABLE [dbo].[Compras_Produtos]  WITH CHECK ADD  CONSTRAINT [FK_ComprasProdutos_Compras] FOREIGN KEY([Id_Compra])
REFERENCES [dbo].[Compras] ([IdCompra])
GO
ALTER TABLE [dbo].[Compras_Produtos] CHECK CONSTRAINT [FK_ComprasProdutos_Compras]
GO
ALTER TABLE [dbo].[Compras_Produtos]  WITH CHECK ADD  CONSTRAINT [FK_ComprasProdutos_Produtos] FOREIGN KEY([Id_Produto])
REFERENCES [dbo].[Produtos] ([IdProduto])
GO
ALTER TABLE [dbo].[Compras_Produtos] CHECK CONSTRAINT [FK_ComprasProdutos_Produtos]
GO
ALTER TABLE [dbo].[Marcas]  WITH CHECK ADD  CONSTRAINT [FK_Marcas_Modelos] FOREIGN KEY([Id_Modelo])
REFERENCES [dbo].[Modelos] ([IdModelo])
GO
ALTER TABLE [dbo].[Marcas] CHECK CONSTRAINT [FK_Marcas_Modelos]
GO
ALTER TABLE [dbo].[Produtos]  WITH CHECK ADD  CONSTRAINT [FK_Produtos_Categorias] FOREIGN KEY([Id_Categoria])
REFERENCES [dbo].[Categorias] ([IdCategoria])
GO
ALTER TABLE [dbo].[Produtos] CHECK CONSTRAINT [FK_Produtos_Categorias]
GO
ALTER TABLE [dbo].[Produtos]  WITH CHECK ADD  CONSTRAINT [FK_Produtos_Marcas] FOREIGN KEY([Id_Marca])
REFERENCES [dbo].[Marcas] ([IdMarca])
GO
ALTER TABLE [dbo].[Produtos] CHECK CONSTRAINT [FK_Produtos_Marcas]
GO
ALTER TABLE [dbo].[Produtos]  WITH CHECK ADD  CONSTRAINT [FK_Produtos_Modelos] FOREIGN KEY([Id_Modelo])
REFERENCES [dbo].[Modelos] ([IdModelo])
GO
ALTER TABLE [dbo].[Produtos] CHECK CONSTRAINT [FK_Produtos_Modelos]
GO
ALTER TABLE [dbo].[Produtos]  WITH CHECK ADD  CONSTRAINT [FK_Produtos_Tipos] FOREIGN KEY([Id_Tipo])
REFERENCES [dbo].[Tipos] ([IdTipo])
GO
ALTER TABLE [dbo].[Produtos] CHECK CONSTRAINT [FK_Produtos_Tipos]
GO
ALTER TABLE [dbo].[Produtos_Vendas]  WITH CHECK ADD  CONSTRAINT [FK_ProdutosVendas_Produtos] FOREIGN KEY([Id_Produto])
REFERENCES [dbo].[Produtos] ([IdProduto])
GO
ALTER TABLE [dbo].[Produtos_Vendas] CHECK CONSTRAINT [FK_ProdutosVendas_Produtos]
GO
ALTER TABLE [dbo].[Produtos_Vendas]  WITH CHECK ADD  CONSTRAINT [FK_ProdutosVendas_Vendas] FOREIGN KEY([Id_Venda])
REFERENCES [dbo].[Vendas] ([IdVenda])
GO
ALTER TABLE [dbo].[Produtos_Vendas] CHECK CONSTRAINT [FK_ProdutosVendas_Vendas]
GO
ALTER TABLE [dbo].[Tipos]  WITH CHECK ADD  CONSTRAINT [FK_Tipos_Marcas] FOREIGN KEY([Id_Marca])
REFERENCES [dbo].[Marcas] ([IdMarca])
GO
ALTER TABLE [dbo].[Tipos] CHECK CONSTRAINT [FK_Tipos_Marcas]
GO
ALTER TABLE [dbo].[Vendas]  WITH CHECK ADD  CONSTRAINT [FK_Vendas_Clientes] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[Vendas] CHECK CONSTRAINT [FK_Vendas_Clientes]
GO
ALTER TABLE [dbo].[Vendas]  WITH CHECK ADD  CONSTRAINT [FK_Vendas_Vendedor] FOREIGN KEY([Id_Vendedor])
REFERENCES [dbo].[Vendedores] ([IdVendedor])
GO
ALTER TABLE [dbo].[Vendas] CHECK CONSTRAINT [FK_Vendas_Vendedor]
GO
ALTER TABLE [dbo].[Vendas_Pagamentos]  WITH CHECK ADD  CONSTRAINT [FK_VendasPagamentos_Pagamentos] FOREIGN KEY([Id_Pagamento])
REFERENCES [dbo].[Pagamentos] ([IdPagamento])
GO
ALTER TABLE [dbo].[Vendas_Pagamentos] CHECK CONSTRAINT [FK_VendasPagamentos_Pagamentos]
GO
ALTER TABLE [dbo].[Vendas_Pagamentos]  WITH CHECK ADD  CONSTRAINT [FK_VendasPagamentos_Vendas] FOREIGN KEY([Id_Venda])
REFERENCES [dbo].[Vendas] ([IdVenda])
GO
ALTER TABLE [dbo].[Vendas_Pagamentos] CHECK CONSTRAINT [FK_VendasPagamentos_Vendas]
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertCategoria]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_InsertCategoria]
@Categoria varchar(100)
as
Insert into Categorias Values(@Categoria)
Select @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertMarca]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_InsertMarca]
@Marca varchar(100)
as
Insert into Marcas Values(null,@Marca)
Select @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertModelo]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_InsertModelo]
@Modelo varchar(100)
as
Insert into Modelos Values(@Modelo)
Select @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertPagamento]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_InsertPagamento]
@DataPag datetime,
@TipoPag varchar(100),
@Valor money,
@Categoria varchar(100)
as
Insert into Pagamentos values(@DataPag,@TipoPag,@Valor,@Categoria)
Select @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertProduto]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_InsertProduto]
@Id_Categoria int,
@Id_Tipo int,
@Id_Marca int,
@Id_Modelo int,
@Produto varchar(100),
@Descricao varchar(100),
@ValorCompra money,
@ValorVenda money,
@Estoque int,
@Estado bit,
@EstoqueMin int
as
Insert into Produtos Values(@Id_Categoria,@Id_Tipo,@Id_Marca,@Id_Modelo,@Produto,@Descricao,@ValorCompra,@ValorVenda,@Estoque,@Estado,@EstoqueMin)
Select @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertTipo]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_InsertTipo]
@Tipo varchar(100)
as
Insert into Tipos Values(null,@Tipo)
Select @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertVenda]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_InsertVenda] 
@Id_Cliente int, 
@Id_Vendedor int,
@DataVenda datetime,
@TipoComprovante varchar(100),
@NumeroComprovante varchar(100),
@Total money,
@TotalPago money,
@TipoVenda varchar(100)
as
Insert into Vendas values(@Id_Cliente,@Id_Vendedor,@DataVenda,@TipoComprovante,@NumeroComprovante,@Total,@TotalPago,@TipoVenda)
Select @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[SP_NovaCompra]    Script Date: 20/07/2021 08:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_NovaCompra]
@Id_Fornecedor int,
@DataCompra datetime,
@Compra varchar(100),
@ValorTotal money,
@ValorFrete money,
@NotaFiscal varchar(100)
as
Insert Into Compras Values(@Id_Fornecedor, @DataCompra, @Compra, @ValorTotal, @ValorFrete, @NotaFiscal)

select @@IDENTITY
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
         Begin Table = "CP"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "P"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_ProdutosCompra'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_ProdutosCompra'
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
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Pr"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ca"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 234
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ti"
            Begin Extent = 
               Top = 6
               Left = 272
               Bottom = 119
               Right = 468
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ma"
            Begin Extent = 
               Top = 6
               Left = 506
               Bottom = 119
               Right = 702
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mo"
            Begin Extent = 
               Top = 6
               Left = 740
               Bottom = 102
               Right = 936
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_ProdutosGrid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_ProdutosGrid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_ProdutosGrid'
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
         Begin Table = "Pv"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pr"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_ProdutosVenda'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_ProdutosVenda'
GO
USE [master]
GO
ALTER DATABASE [VendasOficina] SET  READ_WRITE 
GO
