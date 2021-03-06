USE [Courses]
GO
/****** Object:  Table [dbo].[answer]    Script Date: 17.04.2020 22:00:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[answer](
	[answerId] [int] IDENTITY(1,1) NOT NULL,
	[answerText] [nvarchar](max) NOT NULL,
	[questionId] [int] NOT NULL,
 CONSTRAINT [PK_answer] PRIMARY KEY CLUSTERED 
(
	[answerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[badge]    Script Date: 17.04.2020 22:00:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[badge](
	[badgeId] [int] IDENTITY(1,1) NOT NULL,
	[badgeName] [nvarchar](150) NOT NULL,
	[badgeImage] [varbinary](max) NULL,
	[moduleId] [int] NULL,
 CONSTRAINT [PK_badge] PRIMARY KEY CLUSTERED 
(
	[badgeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[correctAnswer]    Script Date: 17.04.2020 22:00:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[correctAnswer](
	[correctAnswerId] [int] IDENTITY(1,1) NOT NULL,
	[question] [int] NOT NULL,
	[answer] [int] NULL,
 CONSTRAINT [PK_correctAnswer] PRIMARY KEY CLUSTERED 
(
	[correctAnswerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[module]    Script Date: 17.04.2020 22:00:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[module](
	[moduleId] [int] IDENTITY(1,1) NOT NULL,
	[moduleName] [nvarchar](max) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[moduleImage] [varbinary](max) NULL,
 CONSTRAINT [PK_module] PRIMARY KEY CLUSTERED 
(
	[moduleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[question]    Script Date: 17.04.2020 22:00:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[question](
	[questionId] [int] IDENTITY(1,1) NOT NULL,
	[questionText] [nvarchar](max) NOT NULL,
	[testId] [int] NOT NULL,
 CONSTRAINT [PK_question] PRIMARY KEY CLUSTERED 
(
	[questionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[result]    Script Date: 17.04.2020 22:00:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[result](
	[resultId] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
	[badgeId] [int] NOT NULL,
 CONSTRAINT [PK_result] PRIMARY KEY CLUSTERED 
(
	[resultId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[submodule]    Script Date: 17.04.2020 22:00:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[submodule](
	[submoduleId] [int] IDENTITY(1,1) NOT NULL,
	[submoduleName] [nvarchar](max) NOT NULL,
	[submoduleText] [nvarchar](max) NOT NULL,
	[submoduleImage] [varbinary](max) NULL,
	[moduleId] [int] NULL,
 CONSTRAINT [PK_submodule] PRIMARY KEY CLUSTERED 
(
	[submoduleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[test]    Script Date: 17.04.2020 22:00:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[test](
	[testId] [int] IDENTITY(1,1) NOT NULL,
	[testName] [nvarchar](max) NOT NULL,
	[moduleId] [int] NULL,
 CONSTRAINT [PK_test] PRIMARY KEY CLUSTERED 
(
	[testId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 17.04.2020 22:00:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[surname] [nvarchar](100) NOT NULL,
	[firstname] [nvarchar](100) NOT NULL,
	[dob] [date] NOT NULL,
	[sex] [nvarchar](50) NOT NULL,
	[userPhoto] [varbinary](max) NULL,
	[userLogin] [nvarchar](100) NOT NULL,
	[userPassword] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[answer]  WITH CHECK ADD  CONSTRAINT [FK_answer_question] FOREIGN KEY([questionId])
REFERENCES [dbo].[question] ([questionId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[answer] CHECK CONSTRAINT [FK_answer_question]
GO
ALTER TABLE [dbo].[badge]  WITH CHECK ADD  CONSTRAINT [FK_badge_module] FOREIGN KEY([moduleId])
REFERENCES [dbo].[module] ([moduleId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[badge] CHECK CONSTRAINT [FK_badge_module]
GO
ALTER TABLE [dbo].[correctAnswer]  WITH CHECK ADD  CONSTRAINT [FK_correctAnswer_question] FOREIGN KEY([question])
REFERENCES [dbo].[question] ([questionId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[correctAnswer] CHECK CONSTRAINT [FK_correctAnswer_question]
GO
ALTER TABLE [dbo].[question]  WITH CHECK ADD  CONSTRAINT [FK_question_test] FOREIGN KEY([testId])
REFERENCES [dbo].[test] ([testId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[question] CHECK CONSTRAINT [FK_question_test]
GO
ALTER TABLE [dbo].[result]  WITH CHECK ADD  CONSTRAINT [FK_result_badge] FOREIGN KEY([badgeId])
REFERENCES [dbo].[badge] ([badgeId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[result] CHECK CONSTRAINT [FK_result_badge]
GO
ALTER TABLE [dbo].[result]  WITH CHECK ADD  CONSTRAINT [FK_result_users] FOREIGN KEY([userId])
REFERENCES [dbo].[users] ([userId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[result] CHECK CONSTRAINT [FK_result_users]
GO
ALTER TABLE [dbo].[submodule]  WITH CHECK ADD  CONSTRAINT [FK_submodule_module] FOREIGN KEY([moduleId])
REFERENCES [dbo].[module] ([moduleId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[submodule] CHECK CONSTRAINT [FK_submodule_module]
GO
ALTER TABLE [dbo].[test]  WITH CHECK ADD  CONSTRAINT [FK_test_module] FOREIGN KEY([moduleId])
REFERENCES [dbo].[module] ([moduleId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[test] CHECK CONSTRAINT [FK_test_module]
GO
