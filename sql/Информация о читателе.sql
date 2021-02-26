CREATE TABLE [dbo].[Информация о читателе](
	[Номер билета] [int] NOT NULL,
	[Фамилия] [varchar](80) NULL,
	[Имя] [nvarchar] (50) NULL,
	[Отчество] [nvarchar] (70) NULL,
	[Телефон] [nvarchar] (9) NULL,
	[Дата рождения] [date] NULL,
	[Лимит] [int] NULL,
	[Адрес] [nvarchar] (70) NULL,
 CONSTRAINT [PK_Код Номер билета] PRIMARY KEY CLUSTERED 
(
	[Номер билета] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
