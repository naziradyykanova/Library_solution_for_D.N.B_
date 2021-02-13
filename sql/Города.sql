CREATE TABLE [dbo].[Города](
	[Код города] [int] NOT NULL,
	[Наименование] [nvarchar] (80) NULL,
 CONSTRAINT [PK_Код Код города] PRIMARY KEY CLUSTERED 
(
	[Код города] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO