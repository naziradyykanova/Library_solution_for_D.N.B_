CREATE TABLE [dbo].[Разделы библиотеки](
	[Код раздела] [int] NOT NULL,
	[Научная литература] [int] NULL,
	[Журнальные публикации] [nvarchar] (80) NULL,
 CONSTRAINT [PK_Код Код раздела] PRIMARY KEY CLUSTERED 
(
	[Код раздела] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO