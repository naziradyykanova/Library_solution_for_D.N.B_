CREATE TABLE [dbo].[Задолжники](
	[Код задолжника] [int] NOT NULL,
	[Фамилия] [int] NULL,
	[Имя] [int] NULL,
	[Отчество] [int] NULL,
	[Дата выдачи] [int] NULL,
 CONSTRAINT [PK_Код Код задолжника] PRIMARY KEY CLUSTERED 
(
	[Код задолжника] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO