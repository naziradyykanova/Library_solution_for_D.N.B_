


CREATE TABLE [dbo].[Информация о книге](
	[Шифр книги] [int] NOT NULL,
	[Название] [nvarchar] (120) NULL,
	[Код издательства] [int] NULL,
	[Год издания] [date] NULL,
	[Объем книги] [int] NULL,
	[Цена] [double] NULL,
	[Количество] [int] NULL,
	[Код раздела] [int] NULL,
 CONSTRAINT [PK_Код Шифр книги] PRIMARY KEY CLUSTERED 
(
	[Шифр книги] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO