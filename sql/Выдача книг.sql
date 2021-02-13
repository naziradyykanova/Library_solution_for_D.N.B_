CREATE TABLE [dbo].[Выдача книг](
	[Код выдачи] [int] NOT NULL,
	[Шифр книги] [int] NULL,
	[Код читательского билета] [int] NULL,
	[Дата выдачи книги] [datetime] NULL,
	[Дата возврата книги] [datetime] NULL,
 CONSTRAINT [PK_Код Код выдачи] PRIMARY KEY CLUSTERED 
(
	[Код выдачи] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO