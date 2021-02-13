CREATE TABLE [dbo].[Бронирование книг](
	[Код брони] [int] NOT NULL,
	[Код читательского билета] [int] NULL,
	[Дата заказа] [datetime] NULL,
 CONSTRAINT [PK_Код Код брони] PRIMARY KEY CLUSTERED 
(
	[Код брони] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO