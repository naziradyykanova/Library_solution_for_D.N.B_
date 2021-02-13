

CREATE TABLE [dbo].[Авторы](
	[Код автора] [int] NOT NULL,
	[Фамилия] [varchar](80) NULL,
	[Имя] [nvarchar] (50) NULL,
	[Отчество] [nvarchar] (70) NULL,
 CONSTRAINT [PK_Код Код автора] PRIMARY KEY CLUSTERED 
(
	[Код автора] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO