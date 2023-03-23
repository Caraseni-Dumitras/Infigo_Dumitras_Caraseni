USE [CMSPlus]
GO

/****** Object:  Table [dbo].[Comments]    Script Date: 3/21/2023 ******/

/*Create initial comments table*/
CREATE TABLE [dbo].[Comments](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Description] [nvarchar](500) NOT NULL,
    [TopicId] [int] NOT NULL,
    PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
    ) ON [PRIMARY]
    GO

/*Add foreign key constraint for one-to-many*/
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT fk_comment_topic
FOREIGN KEY (TopicId)
REFERENCES Topics(Id);
GO