USE [Publishers]
GO

/****** Object:  Table [dbo].[BookAuthor]    Script Date: 3/12/2013 2:14:19 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BookAuthor](
	[BookID] [bigint] NOT NULL,
	[AuthorID] [bigint] NOT NULL,
 CONSTRAINT [PK_BookAuthor] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC,
	[AuthorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[BookAuthor]  WITH CHECK ADD FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Author] ([ID])
GO

ALTER TABLE [dbo].[BookAuthor]  WITH CHECK ADD FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Author] ([ID])
GO

ALTER TABLE [dbo].[BookAuthor]  WITH CHECK ADD FOREIGN KEY([BookID])
REFERENCES [dbo].[Book] ([ID])
GO

ALTER TABLE [dbo].[BookAuthor]  WITH CHECK ADD FOREIGN KEY([BookID])
REFERENCES [dbo].[Book] ([ID])
GO


