
CREATE TABLE [dbo].[Авторы книг](
	[Код записи] [int] NOT NULL,
	[Шифр книги] [int] NULL,
	[Код автора] [int] NULL,
 CONSTRAINT [PK_Код Код записи] PRIMARY KEY CLUSTERED 
(
	[Код записи] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO