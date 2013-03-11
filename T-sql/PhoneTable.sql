USE [Publishers]
GO

/****** Object:  Table [dbo].[Phone]    Script Date: 3/12/2013 2:14:31 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Phone](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[PublisherID] [bigint] NOT NULL,
	[PhoneTypeID] [bigint] NOT NULL,
	[Number] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Phone]  WITH CHECK ADD FOREIGN KEY([PhoneTypeID])
REFERENCES [dbo].[PhoneType] ([ID])
GO

ALTER TABLE [dbo].[Phone]  WITH CHECK ADD FOREIGN KEY([PhoneTypeID])
REFERENCES [dbo].[PhoneType] ([ID])
GO

ALTER TABLE [dbo].[Phone]  WITH CHECK ADD FOREIGN KEY([PublisherID])
REFERENCES [dbo].[Publisher] ([ID])
GO

ALTER TABLE [dbo].[Phone]  WITH CHECK ADD FOREIGN KEY([PublisherID])
REFERENCES [dbo].[Publisher] ([ID])
GO


