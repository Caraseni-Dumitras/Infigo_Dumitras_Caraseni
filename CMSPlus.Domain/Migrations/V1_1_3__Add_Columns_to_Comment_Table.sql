USE [CMSPlus]
GO


/*Add new columns to comments table*/
ALTER TABLE [dbo].[Comments]
ADD [FullName] [varchar](50) NOT NULL DEFAULT 'Anonymous',
[CreatedOnUtc] [datetime] NOT NULL,
[UpdatedOnUtc] [datetime] NOT NULL
GO

ALTER TABLE [dbo].[Comments] ADD  DEFAULT (getdate()) FOR [CreatedOnUtc]
ALTER TABLE [dbo].[Comments] ADD  DEFAULT (getdate()) FOR [UpdatedOnUtc]