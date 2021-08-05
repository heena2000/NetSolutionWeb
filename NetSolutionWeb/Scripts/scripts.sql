INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'71a157b8-0e47-484e-b396-c28027e7d5e3', N'admin', N'admin', N'cc1c73dc-bcac-414d-bc4f-b4f7a3f592e6')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'2a09aca0-949b-4dca-97ff-ed2d22edfacc', N'admin@netsolutions.com', N'ADMIN@NETSOLUTIONS.COM', N'admin@netsolutions.com', N'ADMIN@NETSOLUTIONS.COM', 1, N'AQAAAAEAACcQAAAAEAatv9KnkBh5s/UAqBEslaX+6SHFgbnly/bBNOAj8V7QPYS1jOdn4Xfjka1XsHdA8w==', N'OY6RUVWEUDJBT4RF4KTYDO36RSJVL6XC', N'882d1a56-8785-4356-8abe-5804159bed10', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'3c5bd9af-b1bc-4b26-949b-831663f431dd', N'liam@gmail.com', N'LIAM@GMAIL.COM', N'liam@gmail.com', N'LIAM@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEMfGHWl9O3n2LNVQ2CA+kE2O1s+FfADV9W3QtfmHcA/HbAR0Se4rU/Mj0BsQzs6FUQ==', N'2WTHEYJAJM2JIKIRUVQUZWBOC7OBAVWW', N'87fe22d1-2e8b-4e83-a88a-fdffe4499599', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2a09aca0-949b-4dca-97ff-ed2d22edfacc', N'71a157b8-0e47-484e-b396-c28027e7d5e3')
GO
SET IDENTITY_INSERT [dbo].[Careers] ON 
GO
INSERT [dbo].[Careers] ([CareerID], [Name], [EmailID], [ContactNo], [ExtName]) VALUES (1, N'Pauline W McConkey', N'Pauline@gmail.com', N'(028) 3171-289', N'.pdf')
GO
INSERT [dbo].[Careers] ([CareerID], [Name], [EmailID], [ContactNo], [ExtName]) VALUES (2, N'Diane J Beahm', N'diane@gmail.com', N'(029) 8623-799', N'.pdf')
GO
INSERT [dbo].[Careers] ([CareerID], [Name], [EmailID], [ContactNo], [ExtName]) VALUES (3, N'John V Alexander', N'john@gmail.com', N'(029) 2203-798', N'.pdf')
GO
INSERT [dbo].[Careers] ([CareerID], [Name], [EmailID], [ContactNo], [ExtName]) VALUES (4, N'Milford E Jackson', N'milford@gmail.com', N'(021) 3408-206', N'.pdf')
GO
SET IDENTITY_INSERT [dbo].[Careers] OFF
GO
SET IDENTITY_INSERT [dbo].[Quotes] ON 
GO
INSERT [dbo].[Quotes] ([QuoteID], [Name], [EmailID], [ContactNo], [Budget], [QuoteText]) VALUES (1, N'Van L Noyes', N'noyes@gmail.com', N'(022) 6717-473', 15000, N'I want to build an application for accessing my all employee details.')
GO
SET IDENTITY_INSERT [dbo].[Quotes] OFF
GO
SET IDENTITY_INSERT [dbo].[Stories] ON 
GO
INSERT [dbo].[Stories] ([StoryID], [ClientName], [TagLine], [Industry], [Features], [ExtName]) VALUES (1, N'Euro Car Parts', N'Setting the UK’s Largest Car Parts Distributor up for E-Commerce Success', N'Automotive', N'Bespoke eCommerce Platform Multilingual & Multisite Capability Label Printing & Warehouse', N'.PNG')
GO
INSERT [dbo].[Stories] ([StoryID], [ClientName], [TagLine], [Industry], [Features], [ExtName]) VALUES (2, N'Hubpix', N'The Future of In-store Advertisements for Convenience Sectors with a Unique Platform that Connects Brands and Retailers', N'Digital Solutions', N'Ecosystem Mapping Conducting Field Research Ecosystem Maps (Ecosystem Mapping)', N'.PNG')
GO
INSERT [dbo].[Stories] ([StoryID], [ClientName], [TagLine], [Industry], [Features], [ExtName]) VALUES (3, N'CXO', N'It all started with the idea of providing CXOs with the information they want in the right format at the right time. The motive was to empower them to make business decisions with a few clicks and all', N'Data Science Solutions', N'A brand new, first of its kind mobile data monitoring platform for CXOs, providing them with a 360 degree view of the organization.', N'.PNG')
GO
SET IDENTITY_INSERT [dbo].[Stories] OFF
GO
SET IDENTITY_INSERT [dbo].[Testimonials] ON 
GO
INSERT [dbo].[Testimonials] ([TestimonialID], [PersonName], [Designation], [CompanyName], [TestimonialText]) VALUES (1, N'Jaspinder Singh ', N'Software Development Manager', N' IMG UK LTD.', N'Net Solutions provided excellent support in the areas of website engineering and site optimization. I can confidently recommend Net Solutions as a dedicated and reliable supplier, and experts in their field.')
GO
INSERT [dbo].[Testimonials] ([TestimonialID], [PersonName], [Designation], [CompanyName], [TestimonialText]) VALUES (2, N'Sean Devlin', N'Co-Founder & Product Manager', N'Front Rush', N'Net Solutions is our Outsourcing partner. They really focus on customers and understand their business objectives. We worked with them for over 10 years and they have really done an outstanding job for us.')
GO
INSERT [dbo].[Testimonials] ([TestimonialID], [PersonName], [Designation], [CompanyName], [TestimonialText]) VALUES (3, N'Steve Brendish', N'Director ', N'Australian Stealth Startup', N'They''ve been extremely flexible in their process for delivering our project, just what our startup needed. It has been an extremely positive experience.')
GO
INSERT [dbo].[Testimonials] ([TestimonialID], [PersonName], [Designation], [CompanyName], [TestimonialText]) VALUES (4, N'Will Paterson', N'Co-Founder', N'ED Place', N'I just loved three things about Net Solutions - culture, quality, and desire. Their confidence in quality and their understanding for the client''s passion are great.')
GO
INSERT [dbo].[Testimonials] ([TestimonialID], [PersonName], [Designation], [CompanyName], [TestimonialText]) VALUES (5, N'Daniel Wolfe', N'CEO', N'SOAQ', N'Working with Net Solutions for the past 8 years has re-enforced our decision to not only outsource some of our software development but also to continue working with them as our partner.')
GO
SET IDENTITY_INSERT [dbo].[Testimonials] OFF
GO
