CREATE TABLE [dbo].[Издательства](
	[Код издательства] [int] NOT NULL,
	[Наименование] [nvarchar] (80) NULL,
	[Код города] [int] NULL,
 CONSTRAINT [PK_Код Код издательства] PRIMARY KEY CLUSTERED 
(
	[Код издательства] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO