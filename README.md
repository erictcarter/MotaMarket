# MotaMarket
Mota Market Cross-Platform Mobile Application 











Eric Tatenda Chemhere (R162494N)










Mota Market Cross-Platform Mobile Application 





By 
Eric Tatenda Chemhere (R162494N)

Submitted in partial fulfilment of the requirements for the degree of

 BSc  Information Systems 

Department of Computer Science and Information Systems
in the 
Faculty of Science and Technology
at the 
Midlands State University 
Gweru
September, 2020
Supervisor: 		Ms. B Mugoniwa






ABSTRACT 
The basis of this thesis is underlined by the fact that users of mobile applications simply wants to access same services regardless of the type of device and type of software. The obvious answer to this is cross platform mobile applications. To avoid compromises in user experience, software design and reliability, this research breaks ground in all aspects because the delivery approach produced a native cross platform mobile application. C# was the programming language of choice because of its powerful Xamarin Forms graphic user interfaces, native package library and 95% shared code base. The end result was a powerful native Android and iOS cross platform mobile application. Even though this research is a first in terms of delivering a native mobile application using C# and Xamarin, the extent of its validity is only measured based on day-to-day Zimbabwean challenges it can address. There is an adoption gap across sectors of industry pertaining to cross platform mobile application henceforth this project went on to cover a void in the motor vehicles market. Zimbabwe has an open market of buying and selling motor vehicles but there are coherent challenges experienced by both motor vehicle buyers and buyers. Mota Market is a native cross platform mobile application available for Android and iOS users to have a platform to facilitate digital marketing, buying and selling of motor vehicles particularly bikes, cars and trucks. The end results was a cloud powered one-stop Mota Market optimizing the efficiency of C# and the stunning user interface of Xamarin Forms.















i

DECLARATION 

I, Eric Chemhere, hereby declare that I am the sole author of this dissertation. I authorize the Midlands State University to lend this dissertation to other institutions or individuals for the purpose of scholarly research.


Signature: …………………………………………….         
Date: ………………………………..















ii

APPROVAL 

This dissertation, entitled “Mota Market Cross Platform Mobile Application” by Eric T Chemhere meets the regulations governing the award of the degree of BSc Honours Information Systems of the Midlands State University, and is approved for its contribution to knowledge and literary presentation.


Supervisor’s Signature …………………………………………

Date: …………………………………………………………………..











iii

ACKNOWLEDGEMENTS 

This research is an accomplished milestone all attributed to the support and guidance that I received. The documentation of this research provides detailed information of this research in the most optimum way possible within the format of the degree programme, I want to thank my Supervisor, Mrs Mugoniwa this is the second dissertation working together. This thesis included implementation and I couldn’t have done it without the astute dedication of the following individuals. I recognize Dr. Zhou for teaching me introduction to C#, a programming language that has become my playground and lifeline. I cannot leave my Lecturer responsible for shaping my business acumen, Mr. Msungwini is a pillar in my academic journey, my Supervisor who came all the way to South Africa during my attachment. Udemy Instructor Vladimir Zhbanko PhD from Manchester University for gave me free access to study artificial intelligence and algorithms using computer programming languages R, C++, MQL4, VBA and Python.  Guillermo Molina from the University of Phoenix sharpened my exposure in developing mobile applications using C# and Xamarin Forms. My all-weather friends, you are the best. To my family, you went out of your ways to ensure that my welfare was in place during this journey. My twin-sister, I love you.My parents, you are in my pulse. I wish I individually mentioned all of you.

Thank you all.









iv


DEDICATION 
To students struggling with developing mobile applications, here’s the recipe, the ingredients, and the banquet, feast the code and be better software engineers. To the community of developers working with traditional iOS swift-based apps and java-based Android apps, it’s time to bet on the winning horse which is C# and Xamarin Forms. Your heroics in software engineering battling with the nightmare of bugs, errors and fixes in indubitable but C# is the true promised hope.  To the business community that has run out of patience waiting for robust cross platform mobile applications that will take your business to the next level. My professional colleagues, I took a break last year and promised to come back stronger and I am not gonna let y’all down. My niggas, Tonderai Kanyuchi and Marone Marozwa, keep it real gents. Family and friends, I render ultimate dedication of the entire effort inputted to this research to you. You all deserve the very best and I began on this one.











v


TABLE OF CONTENTS
Contents
CHAPTER ONE: INTRODUCTION	17
Chapter 1: Introduction	17
Background of the study	17
Problem definition	20
Aim	22
Objectives of the research	22
Instruments and Methodology	22
1.5.1 Instruments	22
1.5.2 Methodology	23
Justification and rationale of the study	23
1.7 Conclusion	26
Chapter 2: Planning Phase	27
2.1 Introduction	27
2.2 Business Value	27
2.3 Feasibility Study	28
2.3.1 Technical Feasibility	28
2.3.2 Economic Feasibility	30
2.3.2.1 Costs	30
2.3.1.2 Tangible and Intangible Benefits	31
2.3.1.3 Cost Benefit Analysis	31
2.3.1.4 Investment Appraisal: Return on Investment (ROI)	32
2.3.1.5 The Payback Period	32
2.3.3 Social Feasibility	32
2.3.4 Operational Feasibility	32
2.4 Risk Analysis	33
2.5 Stakeholder Analysis	33
2.6 Work plan	34
2.7 Conclusion	35
Chapter 3: Analysis Phase	35
3.1 Introduction.	35
3.2 Literature Review	36
3.2.1 The ModelView-ViewModel (MVVM)	36
3.3 Weaknesses of the existing systems	38
3.4 Rationale of the Proposed System	39
3.5 Evaluate Alternatives	41
3.5.1 Outsourcing	41
3.5.2 Improvements	41
3.5.3 Developments	41
3.6 Requirements Analysis	42
3.6.1 Functional Requirements	42
3.6.2 Non-functional requirements	43
3.7 Conclusion	44
Chapter 4: Design Phase	45
4.1 Introduction	45
4.2 System Design.	45
4.2.1 Context Diagram.	49
4.2.2 Data Flow Diagram	50
4.3 Architectural design	51
4.4 Physical design	52
4.4.1 Xamarin.IOS binary packages	52
4.4.2 Xamarin.Android binary packages.	53
4.5 Database design	53
4.5.1 The architecture of the database	53
4.5.2 Tables of the database	54
4.6 Program design	58
4.7 Interface design	59
4.7.1 Menu design	59
4.7.1.2 Sub-menu	59
	61
4.7.2 Input design	61
4.7.3 Output design	65
4.8 Pseudo Code	67
4.9 Security design	68
4.9.1 Physical security	68
4.9.2 Network security	68
4.9.3 Operational security	69
4.10 Conclusion	70
Chapter 5: Implementation Phase	71
5.1 Introduction	71
5.2 Coding	71
5.2.1 The Login System	71
5.2.2 Pages	73
5.2.3 Models	74
5.2.4 Api Services	75
5.2.5 Android Main Activity	76
5.2.6 IOS AppDelegate	77
5.3 Testing	77
5.3.1 Routine Testing using Visual Studio 2019	77
5.3.1.1 Static Testing	78
5.3.1.1 Dynamic Testing	78
5.3.2 Automation Testing	79
5.3.2.1 Module Testing	79
5.3.2.2 Subsystem Testing	82
5.4 Installation	86
5.4.1 User Training	86
5.4.2 Data Migration	86
5.4.3 Recommended System Changeover Strategy	86
5.5 Maintenance	86
5.5.1 The Decision Support System	86
5.5.2 Routine Maintenance	87
5.5.3 Routine Backup	87
5.6 Recommendations	89
5.7 Conclusion	90
Reference List	91


ix 



LIST OF ACRONYMS
.NET - Domain Network
AI – Artificial Intelligence
API – Application Programming Interface
ASP.NET – Active Server Pages
C# - C Sharp programming language
DFD – Data Flow Diagram
IDE – Integrated Development Environment
MSSQL – Microsoft Server Query Language
MVC – Model View Controller
MVVM – Model-View View Model
SDK – Software Development Kit
SQLite – Serve Query Lite
XAML – Extensible Application Markup Language






x

LIST OF FIGURES
Figure 1.1 C# Native Application Chain…………………………………………………..2
Figure 1.2 Xamarin Forms Architecture…………………………………………………...3
Figure 1.3 The Silo Approach……………………………………………………………...5
Figure 1.4 Model-View View Model Pattern……………………………………………...8
Figure 1.5 C# APIs………………………………………………………………………….8
Figure 2.1 Waterfall Model……………………………………………………………….19
Figure 3.1 C# Shared Code Base………………………………………………………….20
Figure 3.2 Model-V View-Model Architecture…………………………………………...22
Figure 3.3 User Trends…………………………………………………………………….23
Figure 3.4 Mota Market Case Diagram……………………………………………………27
Figure 4.2.1 System design………………………………………………………………...29
Figure 4.2.2 Login Authentication………………………………………………………...30
Figure 4.2.3 Items and Categories………………………………………………………...30
Figure 4.2.4 Search functionality………………………………………………………….31
Figure 4.2.5 Account flow…………………………………………………………………31
Figure 4.2.6 Vehicle information………………………………………………………….32
Figure 4.2.7 Context Diagram…………………………………………………………….33
Figure 4.2.8 Data Flow Diagram………………………………………………………….34
Figure 4.3 cross platform architecture………………………………………………….....35
Figure 4.3.1 Xamarin Native Platform……………………………………………………36
Figure 4.4.1 Xamarin.iOS…………………………………………………………………36
Figure 4.4.2 Xamarin.Android……………………………………………………………37
Figure 4.5 .The ANSI-SPARC model.architecture ………………………………………38
Figure 4.6.1 Program design……………………………………………………………...42
Figure 4.7.1.1 Home……………………………………………………………………….43
Figure 4.7.1.2 Account Page………………………………………………………………43
Figure 4.7.1.3 Sell Page…………………………………………………………………..44
Figure 4.7.1.4 Adverts…………………………………………………………………….44



                                                                                      









xi
Figure 4.7.1.5 Explore Page………………………………………………………………45
Figure 4.7.2.1 Login……………………………………………………………………….45
Figure 4.7.2.2 Signup……………………………………………………………………..46
Figure 4.7.2.3 Change Password………………………………………………………….46
Figure 4.7.2.4 Add Phone…………………………………………………………………47
Figure 4.7.2.5 Sell…………………………………………………………………………47
Figure 4.7.2.5 Search Page………………………………………………………………..48
Figure 4.7.2.5 AddImage Page……………………………………………………………48
Figure 4.7.3.1 Information Page………………………………………………………….49
Figure 4.7.3.2 Contact Seller……………………………………………………………..50
Figure 4.7.3.3 ItemDetail…………………………………………………………………50
Figure 4.7.3.4 MyAds Page………………………………………………………………50
Figure 4.9.1 Physical Security Architecture……………………………………………..52
Figure 4.9.2 Network Security Architecture……………………………………………..53
Figure 4.9.3 Operational Security Architecture………………………………………….53













Xii



LIST OF TABLES
Table 2.1: Software Requirements                                                            12
Table 2.2: Hardware Requirements                                                           13
Table 2.3 Budget for developing the system                                             14
Table 2.4: Budget for setting up the system                                              14
Table 2.5: Operations Budget                                                                    14
Table 2.6: Tangible Benefits                                                                      15
Table 2.7 Intangible Benefits                                                                     15
Table 2.8: Cost-Benefit Analysis                                                               15
Table 2.9: The Payback Period                                                                  16
Table 2.10 Work plan                                                                                18
Table 4.1 Categories                                                                                  29
Table 4.2 Images                                                                                        29
Table 4.3 User                                                                                            29
Table 4.4 Change Password                                                                       30
Table 4.5 Change Phone                                                                            30
Table 4.6 Vehicle                                                                                       31
Table 4.7 Add Vehicles                                                                             41













xiii

LIST OF APPENDICES
User Manual                                                                                            86
Terms of Use                                                                                           88



















ivx
CHAPTER ONE: INTRODUCTION

Chapter 1: Introduction
1.1 Background of the study

A cross-platform mobile application is a characteristic platform independent system which run on different software platforms of mobile devices such as android and apple iOS. According to Tunali and Erdogan (2015), methods of developing mobile application vary due to user-defined experience, coding effort and development environment. There are different approaches of implementing cross-platform mobile applications which are Silo approach, Web approach, and the Cross-platform native approach. The scope of this research will only cover widely used mobile operating systems which are Android and iOS. 

Android’s Google Play Store and Apple App Store recorded over 2 million mobile applications as of 2018 according to a report by Survey Monkey. Users simply want to access same services across android and iOS mobile applications. Nadella (2018) also argued that users basically circled their day to day lives around mobile applications from e-commerce to optimized health services. This called for the need to develop cross-platform applications with native experience and same user interface designs. According to Madaudo and Scandurra (2018), this is a development approach aimed at delivering multi-platform software. Companies such as Facebook, Twitter and Instagram are now offering cross platform native applications with same user interface designs to their users. 

The Silo approach refers to the native cross platform approach whereby each platform has its own code stack. Java is used to develop the android application, Objective-C or Swift is used for the iOS application and C# for the windows application. However, the Silo approach code sharing and code re-use is not available since these are completely different languages. Technically the multiple codebases for java, swift and c# causes synchronization problems for systems. Multiple teams of developers for each platform are required which is costly. Integrated Development Environments (IDEs) varies for instance XCode for iOS, Android Studio for Android and Visual Studio for Windows. 

The Web approach refers to delivering hybrid native apps through web-viewing using tools such as Apache Cordova, RhoMobile and PhoneGap. Containers such as Docker and Kubernetes are shelled with mobile replication utilities while the native designs are stimulated using JavaScript, CSS and HTML to convert a website into a mobile application. However, web-viewing means the application cannot be deployed to an app store. Offline synchronization is not supported. Developers do not prefer this method due to limited control over root code of utilities in shells. There are also fewer developers using this method hence support is very limited. Programming languages that uses the web approach to deliver mobile applications include React, Django and Ruby on Rails.





The Cross-platform native approach is based on a write once shared code base to deliver native cross platform mobile applications. The preferred methodology for this research is Xamarin Forms, C# and .Net Framework. Smartface and Appcelerator Titanium can also be used to deliver cross-platform native mobile applications using JavaScript. C# and Xamarin Forms utilizes 100% code sharing across android and iOS platforms for developers to write once, and run anywhere. Full API coverage enhances C# and Xamarin Forms to deliver native graphic user interfaces and performance. According to Satya Nadella (2016), “this is probably the best way in a mobile first, cloud first and people first era”.

Xamarin Forms native cross platform application development is backed dated but landmarked in 2011 when a company called Xamarin was formed. In March 2016, Microsoft acquired Xamarin with the goal of bringing cross-platform mobile development to the wider Microsoft developer community and so Xamarin.Forms is now freely available to all users of Visual Studio. The core objective was to deliver native cross platform using .NET libraries which are Xamarin.Forms for the Portable Class Library, Xamarin.iOS for iOS applications and Xamarin.Android for android development. These .NET libraries make up the Xamarin platform. 
 
Figure 1.1 C# Native Application Chain

The Integrated Development Environment for the coding of cross platform mobile application using C# and Xamarin Forms is Visual Studio 2019, which is the version was used in this project. Visual Studio for apple allows debugging of iOS and android applications whereas Visual Studio for windows does not allow debugging of iOS applications. According to Madaudo and Scandurra (2018), cross-platform development tools give the developer the flexibility to write an app that runs on multiple platforms, following the principle ’write-once-run everywhere’. Different tools and approaches are available to support that development, trying to maximize the code that is used across platforms, minimizing the per platform amount of code. The architecture of the native distribution of Xamarin Forms applications is shown below: 
 
Figure 1.2 Xamarin Forms Architecture

This project intends to introduce Mota Market, a native cross-platform mobile application available on apple and android mobile operating systems. The Model-View View-Model (MVVM) architectural pattern on C# will be used to code this project. This system is a digital advertising platform open to all car dealers to advertise motor vehicles for sale to buyers. System features will require users both buyers and seller to sign up and login to access application services. Buyers will be able to search, find, and contact the seller of any motor vehicle of their choice. Sellers on the other hand will be able to upload motor vehicle information including their contact information, price and their location.
To deliver this cross platform native application, this project focuses research on the new way to code once, and deliver to both platforms. This means the application will not be coded twice one for android using java and another for apple using swift or objective c. The application will entirely be programmed using C# and Xamarin Forms since there are packages for a shared code base. The Extensible Application Markup Language (Xaml) will be used to design the user interfaces because it has one root element that handles controls, animation elements, graphics and behaviours. 

Predictive analytics will be used to manipulate data and build regression and classification deep learning models to generate adverts. Version control will enhance the implementation of the decision support system to enhance the use of artificial intelligence algorithms. The objective is to analyse browsing patterns of buyers towards certain types of motor vehicles to come up with search algorithms and preferences for advertising.

1.2.Problem definition
The motor vehicle market has tremendously grown in Zimbabwe despite the changes in the micro and macro-economic environment in Zimbabwe. Thousands of vehicles are imported from all over the world, the majority being ex-Japanese due to their low-cost price. All these imported motor vehicles flood the car sales, garages and some are even being sold in the streets of shopping centres. Buyers use a lot of time search every garage to find the right vehicle they are looking for the right car at the right price. The buyer to seller challenges that come with this process range from communication to valuation concerns among other issue. 
The traditional coding of native applications deliver different user-interface paradigms among users of android and iOS. This is due to the fact that on iOS and android navigation controls are different by default providing a different experience as the user scrolls through pages, content and menu options of the application.  Hardware architecture of the screen touch also plays a part to these platform interface variations. Users end up getting used to a given mobile operating system creating culture by phone association for android and iOS devices. 

The development environments varies across platforms but every operating system has its own custom integrated development environment (IDE). It means a programmer has to transition between these various IDEs to develop an application which is not a convenient process. For coding iOS systems XCode for the Mac is used, Android Studio to develop Android applications, and Visual Studio is used code windows-based systems. 

The programming interfaces also vary across platforms due to differences in APIs for android and iOS. An example is the toggling of a Boolean true or false across platforms which will cause different naming conventions because for iPhones and iPads, view is referred as UISwitch. The run-time Api for Android devices refer the widget as a Switch and windows, names a control as a ToggleSwitch. 

The traditional native development embraces three different object-oriented languages for coding. This practise is not efficient, it is costly to implement project as well as routine maintenance. Swift or objective-C has iOS frameworks on XCode to deliver iOS applications. Java utilises android software development kits (SDKs) on Android studio to deliver android applications. C# uses the .Net Library on Visual Studio to deliver windows-based applications.
 
Figure 1.3 The Silo Approach

This research is important because Zimbabwe does not have a local platform for buying and selling motor vehicles that is inclusive to all stakeholders. WhatsApp or Facebook groups are limited in terms of number of people, the market they reach to and are not as effective. There is elimination and barriers to entry since social media marketing group sellers among friends and colleagues only. 
. Moreso, below outlined reasons should also be considered
•	There is no existing online platform for buying and selling in Zimbabwe.
•	Social media platforms such as WhatsApp groups can only contain a limited number of buyers and sellers and this creates barriers to entry into this business. 
•	The digital advertising landscape has evolved around smart technology and the motor vehicles is lagging behind. 
•	Customers need to be fully aware of all the legal information pertaining to vehicles of their choice such as ownership transfer and state of radio licences. 
•	To enhance convenience for buyers to easily identify and compare vehicles of their choice.
•	Some sellers struggle to sell their vehicles because it is not easy to market vehicles to the entire country and agents require huge commissions.
•	To predict preferences of different users, the process has been manual surveys and that is costly hence the use of predictive analytics will ease the search process. 



1.3.Aim

•	Develop a user-friendly digital marketing platform for buying and selling vehicles
•	Deliver a native cross platform solution for apple and android devices
•	To enhance digital marketing of motor vehicles for sale
•	Facilitate communication between buyers and sellers
•	To ease the process of finding cars using location API
•	Using Artificial Intelligence to detect market status and perform sentimental analysis
•	Building a pipeline to stabilize motor vehicle valuation challenges.
1.4.Objectives of the research

•	Create a digital platform to market motor vehicles.
•	To develop a native cross platform application that can be used both on apple and android devices using C# and Xamarin Forms 
•	To create a restful backend Application Programming Interface (API) using Asp.net
•	To embrace cloud-based architecture for mobile applications by deploying Asp.net and all backend services on Azure Cloud.
•	To enhance convenience in the search of buyers and sellers of motor vehicles
•	To stabilize car valuations through price comparisons
•	To perform digital marketing in particular social media marketing.

1.5.Instruments and Methodology
These are tools that were used to develop the mobile application inclusive of front end and backend
1.5.1 Instruments
The following tools will be used to develop the system;
•	Microsoft Visual c# and Xamarin as the core programming language
•	Extensible Markup Language (XAML) for scripting the graphic user interface
•	Microsoft Visual Studio as a core Integrated Development Environment
•	Visual Studio Code for xaml design
•	Microsoft Azure to develop the backend
•	SQL as the database
•	Postman for scripting mailing. 
•	Android Phone for emulation and testing.
•	Json Converter to convert Json code to c# code
•	GitHub Desktop Version to enhance version control
•	Adobe Photoshop for picture designs.
•	Azure Deep Learning Supervised Modelling (Regression and Classification)
•	Adobe Acrobat Pro for document editing
•	Test Project for testing the release package
1.5.2 Methodology

     The following research sources will be used;
•	E-books – electronic books on programming in c#, and Xamarin available from the internet and MSU e-library 
•	GitHub – will enable version control, form the decision support system, and neural network 
•	Docker Hub – for creating a docker container for reproducible research and data science.
•	E-Journals – electronic journals on the e-journals portal on MSU library.
•	Google trends and Google AI – to determine and measure sustainability of Artificial Intelligence in small projects
•	Microsoft Community – for Azure.net backend information and c# code errors discussion.
•	Xamarin University – Xamarin forms information, plugins, and nuggets. 
•	Udemy Academy – Information on Asp.net and 


1.6.Justification and rationale of the study

The Xamarin Forms has all the tools for a complete software development lifecycle. The Xamarin platform facilitates the code design, development and integration. Xamarin Test Cloud manages the project testing and Xamarin Insights handles all the monitoring processes.  Xamarin University is the institution which facilitates training, education, research and development of Xamarin Forms. 

 The Model View ViewModel (MVVM) is used to code cross platform mobile applications using Xamarin Forms. MVVM has built-in dependency injection for efficient interface driven design. It has a lot of plugins already written such location, emails, gallery, network, SQLite, secure storage, phone calls among others. Plugins such as INotifyPropertyChanged reduces workloads on the programmer.
 
Figure 1.4 Model-View View Model Pattern

Every platform has its APIs, programming language, development environment and patterns for interaction. Android apps are written in Java, mostly in Android Studio with the help of the Android Software Development Kit(SDK). iOS apps are written in Swift or Objective-C using XCode and the iOS SDK. Every platform has its own technologies that have to be learned when developing native for that platform. With a cross-platform approach only one technology has to be learned and all developers could work in the same team with the same technologies.

 

Figure 1.5 C# APIs

The need for only one development team avoids the communication effort between multiple teams and inconsistencies between the native apps. When the developers are familiar with the used technologies, they can produce multiple per platform apps at once with only a small amount of platform-specific code. After the initial development the software maintenance costs will be reduced, because only one version has to be maintained.

This project benchmarks research into development of cross platform mobile application. Traditionally this is an expensive technology to deliver since two separate teams must be gathered to deliver for both android and apple. The path of this research is to code once and deliver a native iOS and android application without compromise to the experience and user interface designs. This is all achievable using c# and Xamarin forms with entirely .Net packages.
Simulation devices in Visual studio ranges from the oldest mobile operating system version to the latest ones, at present Android 10 for android devices and iOS 13 for apple devices. The simulated devices emulates the real time output while coding a project. The high-level efficient debugging offered by these emulators provides a fast testing method which helps tracking project progress. 
Shared codebase enhances extended device deployment across devices. Xamarin Forms and C# does not only guarantee cross platform development but it offers across device applications. The project can cover mobile devices of all sizes such as tablets and phablets. Moreover, C# and Xamarin Forms enhances development of applications for televisions and wearable devices like smart watches and IoT embedded devices.
Platform specific code is available because C# offers .Net Libraries and nugget packages for  the Xamarin.Android and the Xamarin.IOS thereby all native elements, speed and functions are not compromised. This is because C# contain functionality such as Getter and Setter methods to deliver better performance applications.
Providing a platform for buying and selling will grow the motor vehicles market. Mota-Market is a one stop digital market that will benefit all stakeholders. Some of the core merits of using this system are convenience, time saving and cost-reduction to both buyers and sellers. 
Stability of motor vehicle valuation is projected based on price competition. The buyers and sellers will be able to compare and compete on prices thereby avoiding duplication of random prices. The pipeline of the application is for buyers to promote their motor vehicles through advertising. 
Digital marketing on this system will be robust and this is not only because of the deep learning algorithms to perform predictive analytics. The system will direct traffic to social media handles of Mota Market which is an efficient marketing strategy to reach out to customers. 
Optimization of algorithms will determine sustainability of deep learning models in this project for data science and reproducible research. The goal is to use predictive analytics for marketing purposes and create a decision support system without tempering with private information such as passwords and core features of the system.
A docker container for data science and reproducible research will enhance development of custom docker image originates will to run Shell/Bat scripts and R Scripts in a neural network. This will be the host environment for deep learning to detect market status, advertise and perform sentimental analysis.
However, Microsoft Graph is one endpoint managing and authenticating software development kits (SDKs) for users, groups, files, mail, notes, contact and tasks in the cloud. Microsoft Cloud service included are Active directory, Exchange, SharePoint, One Drive and Event Planner. It facilitates data services and insights ports that enhances platform independence of APIs.
Robust authentication is still platform specific even though there are some open source packages, infact most of them are outdated and don’t support Microsoft graph. Although a majority of authentication scenarios are mostly standardized across platforms, most modern authentication requires explicit consent. This is only granted via provider-managed dialogs creating complexity for delivering cross platform solutions. For instance, in iOS authentication is via Call endpoints and Override view whereas android authentication adds the Manage continuation to the Call endpoint and Override view.
Mota Market will also not facilitate full e-commerce features beyond marketing and communication between the seller and the client. The reasons are not attributable to implementation of this system feature. This is attributable to reasons which are out of the scope of the research such as the legal process to buy a motor vehicle, agent commissions and the currency transition that the Zimbabwean is experiencing. The scope of this research is to develop a cross platform mobile application for the motor vehicles market with marketing features.

1.7 Conclusion
Cross platform mobile applications are defining an all-inclusive service delivery model in this millennial age. In the same essence users want to access these apps whether on android or apple devices without compromise to the native experience. This research aims to deliver just that and go an extra mile to will implement deep learning concepts and algorithms to enhance more efficiency in the process of buying and selling motor vehicles.














Chapter 2: Planning Phase
2.1 Introduction 
Cross platform mobile applications are now a core model of service delivery in the millennial era.  The scope of this research takes insight into the cross platform technologies by developing a native mobile application with a shared code base, native experience and same user interface designs. The implementation strategy is to use C# and Xamarin forms to deliver one native cross platform application to facilitate alternative and feasibility analysis with the traditional development practices of coding one application twice using swift for iOS and java for the android application. 
This research will implement the cross platform mobile application technology to resolve the buying and selling challenges faced by the car market in Zimbabwe. The scope of this research is to create a mobile application that will bring together buyers and sellers of motor vehicles to one digital marketing platform. The cross platform mobile application to be developed in this project is called Mota Market.
Mota Market is a cross platform mobile application which facilitates the buying and selling of various types of motor vehicles on a digital market. Key features of this include an authenticated signup and login system for both buyers and sellers to access application services. The application services will allow sellers to market their motor vehicles to customers by adding their contact information and details of the motor vehicles for sale. Buyers can search motor vehicles, navigate categories and contact the seller.
2.2 Business Value
A cross platform mobile application offers a shared code base, native experience and shared user interfaces to users of both android and apple devices such as cell phones, phablets and tablets. It means users simply download the mobile application from either google play store or apple app store. Nicole Fisher once noted in a Forbes magazine article that people now spend on average 10 hours per day using their mobile devices. This means users nowadays socialize more and do business more on their mobile devices. 
The Mota Market mobile application innovate the business model of the motor vehicles market by offering convenience to all stakeholders. The system wipes of the hustles of spending more time and money looking for the right motor vehicle. This is a digital market x. The digital marketing features of the system also direct users to social media handles of Mota Market which is a robust way for buyers to reach-out to prospective customers of motor vehicles.
The use of deep learning models to use predictive analytics in generating adverts makes this application an efficient and effective digital car market. Artificial intelligence will use algorithms and analytics on user browsing patterns on the system. The outcomes of these algorithms will come up with per user recommendations on tastes and preferences of motor vehicles and generate custom adverts. 



2.3 Feasibility Study
This refers to determining worthiness of implementing a project using by weighing the different kinds of feasibilities. Types of feasibilities are economic feasibility, social feasibility, operational feasibility and technical feasibility. It is a fundamental aspect to decide whether to proceed or cancel a project according to the Chartered Institute of Project Management. 
2.3.1 Technical Feasibility
The research path of this project is to implement one cross platform mobile application with a shared code base using c# and Xamarin forms. The objective is to deliver a native application with same user interface. Developing an application of this scope is usually done by coding one application twice, using swift for the iOS application and java for the android application. The proposed approach therefore calls for a technical feasibility. The following questions must be asked:
1. How viable is c# and Xamarin forms in delivering native application?
2. To what extent are the c# packages and libraries reliable to accommodate updates without causing any application failures?
3. Is the c# community dependable for application maintenance?
The technical feasibility will also include an examination of the hardware and software requirements to cancel or proceed with implementation. 
Table 2.1: Software Requirements

Software tools	Available resources
Microsoft Visual Studio as the Integrated Development Environment
	Community edition available
Postman for scripting mailing. 
	Community edition registered
Android Phone for emulation and testing.
	Samsung J5 Pro
MacBook for emulating and testing the apple application	Must be acquired
Json Converter to convert Json code to c# code
	Installed
GitHub Desktop Version to enhance version control
	Installed
Adobe Acrobat Pro for document editing
	Trial version
Adobe Photoshop for picture designs.
	Trail version
Visual Studio Code for xaml design
	Available
SQL as the database
	Installed
Microsoft Azure to develop the backend
	One month free subscription (students account can be activated)
H2o for Deep Learning Supervised Modelling 	Available
R and R studio for (Regression and Classification) of algorithms.	Available
Docker Hub to creation of the docker container.	Available


Table 2.2: Hardware Requirements

The table below is a summary of hardware specifications required the implement the system.

Hardware tools	Quantity	Current Resources	Comments
Desktop Computer:
 Microsoft Windows 10 Pro, 64-bit, Intel Core i7 4.5GHz.	2	2	Available:
-One desktop for development and testing
-Another for production testing and deployment.
Printer (colour)	2	1	Use alternatives
Ethernet Cables (2.5 metres)	2	NONE	Must be acquired
Wi-Fi router	1	NONE	Use alternatives or acquire
Emulator: Android phone and Apple MacBook	2	1	Must be acquired
Data Cable	2	1	Must be acquired
USB (4gig)	1	1	Use alternatives or acquire


The evaluation of the above software and hardware specifications indicate that this system is technically feasible to proceed with implementation since the majority of these requirements are readily available.




2.3.2 Economic Feasibility
This is a process of weighing the economic costs and economic benefits of carrying out this project. The project is deemed to be viable if it can a positive return on investment. This is achievable if the economic benefits outweigh the economic costs of undertaking this project.
2.3.2.1 Costs
Table 2.3 Budget for developing the system.

Description	Amount 	Cost Estimate (USD)
Labour (front end and backend)	2	1600
Computers (MacBook and windows desktop)	2	1000
Microsoft Azure(subscription)	2	300
Data Charges		100
Training and development
(c# and Xamarin certification)	2	100
Software subscriptions	3	100
Total 	12	3100

Table 2.4: Budget for setting up the system

Description	Estimated Cost (USD)
Orientation of user of the system	50
System setup and cabling	20
Additional support services	20
Miscellaneous costs like lunch	10
Total cost	100

Table 2.5: Operations Budget
Item information	Expected Costs (US$):
2020	Expected Costs (US$):
2021	Expected Costs (US$):
2022
Software maintenance 	1000	1100	1200
Azure Subscription	300	300	300
Total	1300	1400	1500






2.3.1.2 Tangible and Intangible Benefits
Table 2.6: Tangible Benefits

Description	Expected Costs (USD): 2020	Expected Costs (USD): 2021	Estimated Cost (USD): 2022
Reduction in agent fees	1100	1000	50
Reduction in marketing costs	1000	500	500
Reduction in phone call bill	50	50	50
Estimated expenses	2000	3000	4000
Total 	4600	5000	5500

Table 2.7 Intangible Benefits

Benefits
Secure login and protection of privacy
Convenient search of motor vehicles
Easy access to contact details of sellers

2.3.1.3 Cost Benefit Analysis
It is a project management technique whereby all costs are weighed against all the benefits of a project. 
Table 2.8: Cost-Benefit Analysis
Benefits	Estimated Benefits (USD) 2020	Estimated Benefits (USD) 2021	Estimated Benefits (USD) 2022
Tangible benefits	4500	5000	5500
Intangible benefits	-	-	-
Total 	4500	5000	5500
Costs			
Operations	1300	1400	1500
System setup	1000	-	-
System development	3500	-	-
Total Cost	(5800)	(1400)	(1500)
Net Benefit/ Loss	(1300)	3600	4000





This project is recommended to proceed based on the results of the cost benefit analysis indicate the benefits outweighing costs in the second year and third year. 
2.3.1.4 Investment Appraisal: Return on Investment (ROI)
The formula below is used to calculate return on investment:
Return On Investment = [Total Benefits (TB) – Total Costs(TC) ] 
                                           Total Cost of Development (TCD)

2020 Return On Investment = (4600 – 5800) / (5800) *100 = -20.69%
2021 Year Return On Investment = (5000 – 1400) / (1400) * 100 = 257%
2021 Year Return On Investment = (5500 – 1500) / (1500) * 100 = 267%
Based on return on investment outcomes which are positive and increasing by year, thereby project implementation is recommended.
2.3.1.5 The Payback Period
Table 2.9: The Payback Period

Period	Estimated Capital Inflow
(USD):	Total 
Year 0	(4500)	(4500)
Year 1	3200	(1300)
Year 2	5000	3700

Payback period = 1year + (1300/5000) * 12
                         = 1year 3months
This project can commence based on the outcome of payback period which is 1year 3 months.

2.3.3 Social Feasibility
Social feasibility measures the impact of the project to the social in terms of the benefits and disadvantages. This system does not pose any environmental threats to the society. Barriers to entry into becoming an agent or seller will be eliminated by this system. Some of the barriers include car sale rentals, yet this system is more of a virtual garage which enables an agent to sell a vehicle without owning a physical garage. Therefore this project is socially feasible to proceed with implementation. 

2.3.4 Operational Feasibility
It takes insight on the state of reliability of the project to function as expected. It measures the fitness of the system and features to sustain its functional objectives as more users adopt the system. Given that c# is a well-supported language, updates of core packages and dependencies will ensure that the system will keep on improving to meet the expectations of users.
The backend of the system is Microsoft Azure cloud thereby it can handle more data without affecting functions and features. On the Microsoft Azure cloud, data privacy is protected and back up features are available hence users will not lose their valuable information. The project is recommended to proceed based on the outcomes of the operational feasibility.
2.4 Risk Analysis
Risk analysis look at the possibility of unexpected occurrences during the project implementation phase that may cause delays, scrutinize coding of end user expectations and affect the project as a whole.
Time Factor shown - critical path analysis will be used to draft the possible implementation plans that will be set out in the work plan. Given that time management is very important, the project plan will be guided by the work plan. In order to ensure that any disruption to the critical path does not cause project failure, dummy activities and floats are not ignored.
Limited Resources - scarcity of resources will require opportunity cost to be considered. Opportunity cost is the benefit of the second best alternative which is forgone when a choice is made. Hence resources will have to be ranked in the order of importance when needs be so as to ensure the project proceeds with implementation.
Technical skills – the implementation strategy of this project takes a path that is robust but still new and difficult. There are very limited c# programmers who can develop mobile applications using Xamarin Forms.
Data dependency – the application does not function offline, hence users will need to have data or a Wi-Fi connection to use the application. For security reasons, any connection failure where a user goes offline, the system will automatically sign out the user.
Microsoft Azure Cloud – the SQL backend is connected to Microsoft azure which needs a monthly or yearly subscription. The application is dependable this backend hence the connection stream must always be connected. If this is missed, this can disrupt services.
Data Privacy policy – the application will ensure the user agrees to a data privacy policy to accept liability of their information that they upload at their consent. 

2.5 Stakeholder Analysis
A stakeholder is any party directly or indirectly interested in Mota Market mobile application. Some of the critical stakeholders of this system include buyers, sellers, and the government.
Motor vehicle buyers saves time of going through each and every garage looking for the right vehicle. It is convenient for prospective buyers since they can contact the sellers for more information. 
Motor vehicle sellers can market to a bigger customer base compared to social media marketing such as WhatsApp. It is cheaper to market on this platform compared to renting a garage. 
Government may have to monitor this system to ensure that the proposed motor vehicle prices do not cause inflation. To avoid criminal activities, the system verifies and validate user data to ensure that there is traceability and no fraudulent activities. 

2.6 Work plan
Table 2.10 Work plan 
Stage	 Details	Expected Start Date	Expected End Date	Estimated Deliverables
System proposal	Defining the problem definition, and proposing the solution	05 January 2020	15 January 2020	Aims and objectives,
Tools and Methodology
Planning	Feasibility study, timeline management	17 January 2020	31 January 2020	Feasibility reports
Analyzing	Project appraisal of the technical and data elements	01 March 2020	10 March 2020	Alternative analysis
Designing	Processes, Data flows, 	12 March 2020	21 March 2020	Database engineering and user interfaces
Coding	Software engineering 	22 March 2020	22 April 2020	System features, and utilities.
Implementation	Compile, build test and emulate	23 April 2020	01 May 2020	Production release and publishing to application stores
Maintenance	Updates and upgrades, 
Bugs and fixes	02 May 2020	../…/..	











The Waterfall Model
The Waterfall Model illustrates better the step by step processes that will be followed to implement this system.



Figure 2.1 Waterfall Model


2.7 Conclusion 
The planning phase embraced feasibility study, cost-benefit analysis and time management to determine if this project was viable to implement. All factors of the planning phase were weighed until the recommendation considered the project viable to proceed with the implementation process. 







Chapter 3: Analysis Phase
3.1 Introduction.
The analysis phase will now enhance a complete examination of the benefits and demerits of implementing this system to the stakeholders. The process of going through analysis phase is pivotal for the Mota Market project especially after successfully completing the feasibility checks in the planning phase. The scope of the analysis phase will take insight into alternative analysis and requirements analysis to ensure that the system can be implemented in time and adopted by users.
3.2 Literature Review
The implementation of this project is based on the native cross platform application development using the Xamarin.Forms architecture. Apart from the Native cross platform route, Xamarin Forms stood out as preferred model from other models such as:
	Hybrid Application development using WebView of a native container app.
	Mobile Responsive Web App Development such as Ruby on Rails.
	Platform based Native Development using native languages like swift on XCode for iOS apps.
The cross platform native application development is an all-out efficient method of delivering the Mota Market cross platform over hybrid, mobile responsive web apps and even arguably platform based native apps because of the following attributes:
 
Figure 3.1 C# Shared Code Base





 
3.2.1 The ModelView-ViewModel (MVVM)
The Model View ViewModel (MVVM) is an open-source framework maintained by Stuart Lodge and Co. It is based on the Model-View-Controller (MVC) pattern composes of the IValueCollector, ObservableCollection Tree Class, Wrappers, Fast renders, Layout Compression, Permissions, ListView interactivity and Offline database synchronization. The MVC pattern is natural to the extensible markup language for C# which is XAML used to develop the graphic user interface. The MVVM model utilises data binding on the Model, View and View Model to deliver:
	Easier to maintain
	Easier to test
	Easier to evolve
	Better code reuse
	Enables developer-designer workflow
The Model comprises of the following elements:
	Data Model
	Business and Validation Logic when dealing with classes, configure properties and perform validation
	Typical Classes
The View contains the following attributes:
	Layout of what is on the screen
	Limited code behind, no business logic
	Gets data from View Model through bindings or methods
The ViewModel includes the following features:
	Intermediary between view and model
	View’s Logic
	Provides data from the model to the view
 
Figure 3.2 Model-V View-Model Architecture Pattern 

3.3 Weaknesses of the existing systems

High cost of development and maintenance of mobile applications have hindered the development of cross platform mobile applications. Thereby there are no existent cross platform mobile applications for buying and selling of motor vehicles in Zimbabwe at present. This is because separate teams would have to be hired for android, and iOS apps.
The vast majority of existing systems in Zimbabwe are web applications and this is attributed to the fact that the skills for mobile development are still scares. The worst-case scenario is that of the few mobile application developers, they only cover android applications not iOS.  Moreso most customers now spend much of their time on their mobile phones and web applications do not offer the best optimized and secure experience. Not even a single mobile application is offering this service exist yet still one that is available on android and iOS. The rapid growth of mobile phone usage justifies the great need for mobile applications.
 
Figure 3.3 User Trends

The Zimbabwean local motor vehicle market does not have an all-inclusive marketing platform. The platforms used to import cars from countries such as japan is a complicated process in terms of processing the paperwork, import duty. End customers are not flexible with the process of hiring extra agents, they just want to buy and drive. Challenges with Foreign Currency Accounts (FCAs) contemplate problems because majority of forex circulation in the country right now is in cash in the black market.
The customer base is limited for motor vehicle sellers because without a platform like this one it is difficult to use digital marketing. The use of social media such as WhatsApp groups that can only encompass 257 members limit marketing coverage. Even other social media platforms such as Facebook are still not effective as long as the vehicle market does not have an all-inclusive platform.
The process of buying a motor vehicle on its own is time consuming and complicated for buyers to easily acquire a motor vehicle of choice. Currently customers have to go through each and every car sale garage just to view motor vehicles. This is a complicated and time-consuming process affecting prospective buyers of motor vehicles. 
 Stakeholder communication challenges exist between buyers and sellers is a challenge because there is no platform where customers can easily find contact information of sellers and the increased data charges has only worsened the situation. 
Reliability and convenience are a challenge since current systems do not encompass offline synchronization or use predictive analytics. If the data of a customer runs out while browsing, they lose all their data. If the buyers were searching for a motor vehicle of choice, the search history is lost hence the buyers have to start all over again.

 
3.4 Rationale of the Proposed System

Xamarin Forms provides a rich foundation for style and theming experiences. It uses platform-to-device specific theming concepts and resources to deliver native cross platform experiences. The properties of the styling concepts in Xamarin Forms are rendered on explicit and implicit type values for easier manageability. Style triggers and setter collections enhances property style changes dynamically at runtime by using dynamic resources.
The controls and plugins of Xamarin Forms operate differently from code interpreters to deliver real native experience because they can interpret and render controls for each target platform. When applications use shared code, the Xamarin Forms engine creates platform specific applications that consume the shared code and then maps controls to the platform specific native user interface elements at runtime. This means Xamarin Forms applications use native APIs, user interface controls, native compilers and platform specific hardware acceleration.
Xamarin Forms and the Xamarin Forms APIs can be leveraged to quickly build native applications for iOS and android. Xaml and C# is typically used with over 95% code sharing across platforms. Xamarin Forms is already embedded within the C# IDE which is Visual Studio.
Xamarin cross platform mobile application is the implementation strategy is a very efficient compared to the Silo approach. Using the Silo approach has per platform stacks, no code sharing or re-use, multiple developer teams which is expensive, synchronization problems of multiple code bases and different IDEs. However, the C# and Xamarin Forms approach guarantees:
	native graphic user interfaces
	native system performance
	shared code base across platforms
	Use of C# & .NET framework
	100% API coverage
	Few developers
Just-in-Time (JIT) compilation is the execution model used by C# into the Android core. C# uses Android Callable Wrappers (ACW) and Managed Callable Wrappers (MCW) which are dependencies of Mono.Android.dll.  The .Net Framework APIs and Android binding will stream resources directly using MCW from android and java core which are then passed by the ACW to the mono.
This project compiles and debugs native iOS application using the Ahead of Time (AOT) execution model. It utilises the Portable Class Library features are that it produces a Mono Framework included on the CocoaTouch SDK of an iTunes and App Store binary package.
Support of native apps from Xamarin Forms and C# is easy because they are always up-to-date since Xamarin.iOS offer same-day support for all iOS versions. Xamarin offers full support for  Google Glass, Android Wear, Amazon Fire TV, Apple Watch and more.
Code sharing techniques enhances faster release of applications at a lower cost. There are multiple ways in which you can share code which are portable class libraries (PCLs), partial classes, compiler conditional blocks and shared projects
Model View ViewModel (MVVM) stores the logic in the presenter by isolating the view from the model. MVVM enhances separation of concerns, decoupling, code reuse, and testability. The Model View Controller Pattern is made up of:
	properties
	data binding
	INotifyPropertyChanged
	INotifyCollectionChanged
	IValueConverter
	ICommand
	UI thread
The Xamarin Forms platform supports rich integration with notification registration, tagging and broadcasting services as well as shared platform messaging service publishing and subscription models to easily perform real time in-app notification interactions for both android and iOS. Xamarin registers templates and coordinate communication through:
	Advanced push notification services
	Tagging concepts for pre-provisioned tagging, dynamic tagging and tagging support
	Routing notifications
	Messaging centre
Tagging is a predictive analytics concept whereby artificial intelligence is used to target the masses. Tags enables the targeting of specific set of devices or more specifically registrations when sending a push notification. The only way to target specific registrations is to associate them with a specific tag then target that tag when sending push notifications. 
This project has a very powerful implementation of tags because it utilises both tagging techniques. This is because pre-provisioned tagging is for planned audiences and segmented per devices using client request authentication. For security, stability, performance and services such as Azure Notifications Hub, user must be registered and managed via Azure Client SDK which disables dynamic tagging and forces tags to be pre-provisioned prior to registration or registration update via the invocation of Azure Notifications Hub APIs.
Dynamic tagging is real time or ad-hoc fully supported by Azure Notifications Hub but can’t really be achieved by Mobile Services client used in Xamarin Forms using the Azure Client Mobile SDK. It actually full utilization of the Azure Notifications Hub package or via an external service such as an Azure API App.
Secure native cloud native backend on the Microsoft azure cloud backend of the application is 100% secure. To use the system, users will have to sign up and login and their information is encrypted and saved on the azure SQL database. 
Machine learning algorithms for predictive analytics will be used to generate and sort adverts custom to user taste and preferences. Paid adverts will be automatically sorted to appear first and on top. Search history will also be stored. 
Digital marketing capabilities of this system are so robust, and the digital client base forecast anticipate growth. The application has direct social engines integrated to facilitate social media marketing hence the system can reach out to an unlimited client base. 
Reliability and convenience are guaranteed making the application is easy to use because the navigation is user friendly, secure authenticated login is required to use application services. The system is reliable since the information is stored in a secure cloud database hence any attack or crush will never result in loss of information. 

3.5 Evaluate Alternatives 
3.5.1 Outsourcing 
The outcomes of the feasibility study favoured the implementation of the system over the option to outsource the services. 
Technical feasibility - The evaluation of the software and hardware specifications indicate that this system is technically feasible to proceed with implementation since the majority of these requirements are readily available.
Economic feasibility - This project is recommended to proceed based on the results of the cost benefit analysis indicate the benefits outweighing costs in the second year and third year. 
Social feasibility – the system does not negatively affect the society. It actually address the social classes of inequality by breaking the barriers to entry into the business of selling motor vehicles since registration is free and open to anyone. 
Operational feasibility – concerns of operating the system include security, costs and performance. The azure backend is secure hence privacy and protection of information is guaranteed. Paid advertising will enhance covering up for costs such as monthly subscriptions and it all rests in the power of digital marketing.
3.5.2 Improvements 
This project did not incorporate other e-commerce features such as cart and checkout due to the macro-economic reasons in Zimbabwe. The government has banned all foreign currency pegged transactions. Liquidity crunch and inflation heavily affect the pricing of motor vehicles hence Mota Market system features were restricted to a marketing platform.
3.5.3 Developments 
The development of cross platform native applications using c# is a cheaper model. Using traditional practises, a team developing an android application using java and another for the iOS using swift would have to be gathered. The wage bill and maintenance of these two separate applications is very costly. 
The operating costs of this application will be covered by a financial model for marketing since the system has artificial intelligence algorithms for predictive analytics. Sellers of motor vehicles will have to pay for their adverts to appear first or on top of other users’ adverts especially in search queries. 
3.6 Requirements Analysis 
According to Haruhiko (2013), this arises because of the need to determine the expectations of all users of a system. These can be functional or non-functional requirements.
3.6.1 Functional Requirements 
According to Haruhiko (2014), functional requirements refers to the scope of the system features directly linked to objectives of the project. The functions of the Mota Market system which are directly linked to deliverables can be illustrated in a case diagram.

 
Figure 3.4 Mota Market Case Diagram





3.6.2 Non-functional requirements 
The non-functional requirements of the Mota Market are factors that ensured that the system delivers a simple and robust user-friendly experience to the end users. Simple design patterns and uniform themes were adopted so as to provide end users with a user-friendly experience, scrolling through this application is very simple since c# enhances movement from one page to the other easily. The entire theme for the mobile application is uniformly in blue, where possible users are provided with selected list features to enhance quick usability.
Knowledge Transfer on Microsoft’s c# and Xamarin university have established platforms to learn developing cross platform mobile applications. Microsoft also acquired Github.com which is the largest open source repository. However, it’s arguably not easy to develop real world applications using this technology especially when trying to implement on a backend which is not Microsoft azure. 
Barriers to entry in the motor vehicles industry have been restricted for a few with capital resources to become dealers and agents. This application will allow all dealers to register and while registered agents will have the opportunity sell earning commissions from actual owners. 
Import difficulties for end users when importing motor vehicles is a highlighted major inconvenience in this business particulars customers are the biggest victims. Most customers simply want to buy and drive their motor vehicles. Thereby this application will enhance users to simply look for the vehicle of their choice, contact the seller and buy.
The customer base is very big for motor vehicle sellers as the system uses digital marketing to reach to a broad customer base using the Mota Market such media handles. The time-series analysis and marketing forecasts of the business model projects an even growth in userbase.
Time wastage in car viewing is a huge concern since prospective customers have to go through many garages just viewing cars. A lot of time is spent on travelling to these car sales across the country. This system will bring the viewing experience to customers at their comfort. 

3.7 Conclusion
This analysis phase will enhance an in-depth examination of certain aspects of the project that will ensure that it can successfully be completed and adopted for use by the end user. The scope of the analysis ranged from requirements analysis to alternative analysis and the outcomes recommended the project to proceed. 







Chapter 4: Design Phase
4.1 Introduction
The main focus of this phase is on frontend and backend features implemented on Mota Market mobile application are structured. The scope of the design of the Mota Market mobile application will include system design, architectural design, program design, interface design and pseudo code among others. To illustrate the design phase, context diagram and data flow diagram of the Mota Market mobile application will be used.
4.2 System Design. 
The C# and Xamarin Forms functional design elements of the Mota Market mobile application will enhance the front end and backend architecture to deliver flexibility, usability, portability, reliability and security to the cross-platform applications. C# and Xamarin Forms utilizes three core functions of Xamarin which are data models, data access layer and service access layer to synchronize business logic models of the platform specific code to the local SQLite and Microsoft Azure cloud.
 
Figure 4.1 System design

User will have to signup by entering username, email and password to register. After successful registration, user must enter correct and valid email and password credentials which are required to login to the mobile application. Upon successful login, the user will access the homepage. The user will then scroll through the explore, sell, ads, account and information pages. The sellers will have to contact the system administrator, to have their adverts featured and to appear on top in the advertisements.
 
Figure 4.2 Login Workflow 

On the Explore page, the user can access categories, choose a category of their choice to find vehicle details and item details as shown below:
 

Figure 4.3 Categories and Items




Search tab allows users to use the search function to search for a particular vehicle and the system will feedback optimized search results instantly as shown below:
 
Figure 4.4 Search functionality

The Account page will enhance users to upload profile pictures, change password, change phone and logout functions as shown below:
 
Figure 4.5 Account Page Workflow

A user selling a vehicle, can upload up to 6 images of the vehicle for sale and can fill out information about the vehicle such as condition, price, vehicle name, and location among others.
 

Figure 4.6 Add Vehicle Information














4.2.1 Context Diagram.
This is a simple architectural abstract showing relationships between main application components to the entities according to Kendall etal, (2014).



KEY





Figure 4.7 Context Diagram





4.2.2 Data Flow Diagram
.According.to.Maccoby (2011), the Data Flow Diagram (DFD) shows the roles and relations that connects components of a system. The DFD for Mota Market is shown below:



























Figure 4.8 Data Flow Diagram
4.3 Architectural design
The Mota Market mobile application has a cross platform architecture that deliver one same native app to both android and iOS devices using c# and Xamarin Forms. The shared code base contains data models, data access layer and business logic which goes through the platform specific code before producing native user interface.
 
Figure 4.9 cross platform architecture

The Microsoft Azure backend services will synchronize the admin console to Azure app service which communicates with the service bus for service requests, inspection and log reservation. The Azure SQL database performs cloud serve push, cloud service pool to another service bus for the querying of data. The Asp.net core 3.5 will facilitate backend functions and interlink with Postman to send information to the frontend of the system. 
Even though Xamarin Forms can deliver to all platform, the scope of this project could not justify the relevance of the windows mobile application because currently Microsoft is not supporting the operating system hence all mobile devices are using iOS and android. The scope of the research also did not cover other devices such as wearables and TVs. The architecture of how c# will deliver native mobile applications to android and iOS devices is shown below:
 
Figure 4.10 Xamarin Native Platform
4.4 Physical design 
C# has powerful nugget packages to deliver native APIs on the .Net Framework. These .Net APIs directly invoke system binaries on the primary level and secondary level enhancing native resources to function. The primary and secondary level binary system resources for Xamarin.iOS and Xamarin.Android are the same.
Primary level system binary resources are System.Data, System.Windows, System.Numerics, System.Core and System.ServiceModel. The secondary level system binaries are System.Net, SystemDefault, System.IO, System.Linq and System.Xml.

4.4.1 Xamarin.IOS binary packages
For Xamarin.iOS, the .NET Framework APIs is delivers Mapkits, UIKits, iBeacon, CoreGraphics and CoreMotion.

 
Figure 4.11 Xamarin.iOS



4.4.2 Xamarin.Android binary packages.
For Xamarin.Android, the .NET Framework APIs deliver Text-to-speech, Toolbar, Printing Framework, Renderscript and NFC.  

 

Figure 4.12 Xamarin.Android

4.5 Database design 
According.to Roberta and Dennis (2014), database design is deriving a data model using logically tabled collections. 
4.5.1 The architecture of the database
The architectural design pattern of the database for Mota Market cross platform application will adhere to ANSI-SPARC model. It therefore means that the database schema will comprise of the application layer, external layer and internal layer. The ANSI-SPARC model proposes the database architecture to separate the physical design of the database from the user’s view. 

External Level
This is a secondary level that utilizes an interface to display views for the system and its users. Users of the system will only access information belongs to them only
Internal Level
The internal level shows how the database management system interfaces queries, how data is stored and structured in the SQL database. There is allocation and indexing of data to memory slots. The internal level also aims to encrypt of sensitive information into hardly interpreted data using salts, md5 and sha1.
Conceptual level
The conceptual level is a primary database layer which shows data relations and data definitions. 
 

Figure 4.13 .The ANSI-SPARC model.architecture 


4.5.2 Tables of the database
Tables show the relational data models where related SQL data entries are stored. Tables for the SQL database of this system are categories, images, users and vehicles.
Structure of the Mota Market database
Database name motamarket
Categories table with types of vehicles






Table 4.1 Vehicles

 


Table 4.2 Categories 

 



Table 4.3 User 

 

Table 4.4 Change Password 

 








Table 4.5 Change Phone 

 
Table 4.6 Requests 

 
Table 4.7 Add Vehicles 
 
4.6 Program design 

 



Figure 4.14 Program design





4.7 Interface design
4.7.1 Menu design
 
Figure 4.15 Home 
4.7.1.2 Sub-menu
 
Figure 4.16 Account Page

 
Figure 4.17 Sell Page
 
Figure 4.18 Adverts
 
Figure 4.19 Explore Page
	
 

4.7.2 Input design

Figure 4.19 Login 


 
Figure 4.19 Signup 

 
Figure 4.20 Change Password 
 
Figure 4.21 Add Phone 

 
Figure 4.22 Sell 
 
Figure 4.23 Search Page

Add Image
 
Figure 4.24 AddImage Page


	4.7.3 Output design 

 
Figure 4.25 Information Page
Contact Seller
 
Figure 4.26 Contact Seller 
 
Figure 4.27 ItemDetail 

 
Figure 4.27 MyAds Page
4.8 Pseudo Code 
	Pseudo code uses laymen abstract presentation of the real code or algorithm in a way in which anyone without a programming background can understand.
	
 






4.9 Security design
The Xamarin.Auth package handles authentication and authorization using the Authenticator to handle OAuth flow, Request to make authenticated requests and AccountStore to store credentials. Authentication features prove identity and retrieve claims whilst Authorization manages access and consumes claims. Authenticating with OAuth gives this system layered over OAuth for easy to use APIs, Open standard to define standard scopes and Identity token which provides user information. The key objectives of the security design were:
	To provide or restrict access to data or functionality
	A mechanism in which a user proves who they are by providing a set of credentials.

4.9.1 Physical security
The Mota Market cross platform mobile application has three entry stacks which are server-side, hockey app and azure notification hub. The server-side end-to-end security utilises the on-premise notification gateway, active directory and corporation applications to a firebase throughput where necessary. The hockey app is key in application insights and PowerBI embedded analytics to show results of the state of security which is key since this is a cloud-based application.
 
Figure 4.29 Physical Security Architecture






4.9.2 Network security

The network security of this system is end-to-end on authorization service, authorization boundary and virtual optimization. The authorization service is robust because it passes tokens through the web application server zone of Asp.net core and interlinks workstations open zone. The authorization boundary synchronizes the service port protocol for users’ activity to a firewall before passing the log to the Microsoft azure server open zone. The SQL database uses a closed zone model to process queries from the database hosting, archive management and storage subsystem.
 
Figure 4.30 Network Security Architecture
4.9.3 Operational security
The operational security of the Mota Market cross platform mobile application is designed on three stacks which are agents, cloud and API. The three-stack architecture helps to ensure that the system is secure when the application is in use through caching of login authentication and changing of password among others. The SQL database will use the log analytics repository of all out of function activities. C# is a very powerful coding language because through a log search the results like alerts, exports, dashboards and API can be retrieved.
 


Figure 4.31 Operational Security Architecture
4.10 Conclusion
The design phase produced a clear breakdown of the architectural design of the front end and the backend of the application. To further illustrate, context and data flow diagrams were used. Given that all the critical system features have been clarified through design elements, this gives the spotlight for the project to go ahead to the next phase.



















Chapter 5: Implementation Phase
5.1 Introduction
The implementation phase focuses on the technical project implementation procedures such as coding, testing, installation and maintenance routines adhered to in successfully delivery of the Mota Market cross platform mobile applications. This phase will also incorporate user training and development which is necessary for the adaptation of the system. 
5.2 Coding
The programming of the Mota Market cross platform mobile application is divided between the frontend which used C# and Xamarin Forms and the backend which used Asp.net core 3.5 which then connects via Postman to the Microsoft azure which hosts services and contain the SQL database.
The major elements of the frontend are the pages, models, services, and the platform specific resources for the android and iOS applications. Platform specific resources include root graphic user interface elements for handling controls, animation tools, graphic elements and elements for behaviours. 
5.2.1 The Login System
The Login system involves the Signup and the Login pages that gives access to the system. The authentication of the Login system is connected to an access token valid for 24hours.
  
Figure 5.1 Login Authentication Test

App.xaml Code
 









5.2.2 Pages

 












5.2.3 Models

 

5.2.4 Api Services
 
 

5.2.5 Android Main Activity

 










5.2.6 IOS AppDelegate

 


  
5.3 Testing 
The IDE used to develop this system, Visual Studio 2019 has robust testing features such as building, debug, warning and error reporting which are more necessary during the development of the system. To test the system after publishing it, an automation testing tool called Test Project will be used.
5.3.1 Routine Testing using Visual Studio 2019
The core IDE used to develop this system, Visual Studio 2019 has robust testing features which are in-built and well automated testing tools such as Live Unit Testing, IntelliTest and Coded UI Test. Unit testing is available in all editions of Visual Studio. 

5.3.1.1 Static Testing
The utilities used to conduct static testing are inbuilt to the default Integrated Development Environment (IDE), Visual Studio 2019 for validation and verification syntax. Tools perform live and instant tasks like previewing, code analysis, error reporting, code warning, run with debugging, test while the system development is in process. 

5.3.1.1 Dynamic Testing
1. Signup Validation
The Asp.net verifies that users cannot register an email without the @ character, the system will automatically highlight this issue and the user cannot signup until this parameter is corrected. Other errors include inserting the @ character at the start or end of the email address. If any of the entry fields is empty, the system will highlight the error.
2.Dynamic Testing of Login Validation 
A registered user must enter correct email address and password to login to the system. An unregistered will not be able to login. A registered user can change password and phone number.
 
 Figure 5.2 Login Authentication Test






5.3.2 Automation Testing 
 Azure Cloud has in-built testing tools which were also used to ensure that the application is tested in an automated and pipelined environment. The system went through the stages highlighted below:
 
Figure 5.3 Testing Results



5.3.2.1 Module Testing
Test Project software will carry-out black box testing to ascertain if the system is dependable and reliable. To determine whether the scores are favourable or not, Test Project targets main modules of the cross platform native mobile application which are pages, models and then platform specific API services for android and iOS.












The entire testing process aligned to the phases outlined diagrammatically below:
 
Figure 5.4 Testing Workflow

The module testing below observed the ability of the mobile application to request access native resources such as the gallery to upload images to the mobile application. The test was successful.
 
Figure 5.4 Request Access to Device Gallery 

The mobile application performed the task of requesting access, thereafter the next test was to check if the application can pick images and from the device and upload to the mobile application successfully. This check was successful.
 
Figure 5.5 Adding Vehicle Images

Users of the mobile application had the ability to add their phone number, as demonstrated in the test activity below:
 
Figure 5.6 Add phone number

Search queries were also performed to search to a particular vehicle as shown below:
 
Figure 5.7 Running a Search Query
5.3.2.2 Subsystem Testing
Test Project will also be used to investigate any frontend and backend failures. On the frontend focus will be on any unresponsiveness, delays and unexpected failure of the user interface. For the backend, token request delays, link expiry and query failure will be targeted.
The major aim here was to observe results, in this case to check if added images would appear in the mobile application.
 
Figure 5.8 Getting Added Images











The main focus here was to select bikes and check if the system would return a list of bikes available.
 
Figure 5.9 Getting List of Bikes Selected

The main focus here was to select cars and check if the system would return a list of bikes available.

 
Figure 5.10 Getting list of Cars
The main focus here was to select trucks and check if the system would return a list of bikes available.


 
Figure 5.11 Getting list of Trucks

This test case was to check if vehicle data could be retrieved per vehicle selected.
 
Figure 5.12 Getting Vehicle detail
5.4 Installation 
The installation of mobile application can be on the application stores or outside the application stores. The user simple needs to allow unknown application sources in an out-of-store installation scenario and the application will be installed immediately.
5.4.1 User Training
The system is easy to use but user manuals will be deployed to digital platforms and social media such as Facebook, YouTube, Twitter and Instagram. This will aid users of the system with access to all the information pertaining system functionality, use, requirements, and benefits.  
5.4.2 Data Migration
The Mota Market cross platform mobile application is cloud-based but the integration of asynchronous features like offline synchronization resulted in a data migration strategy being devised.  SQLite database is the first point of data entry within the platform specific databases. The Asp.net core backend API of the system facilitates an encrypted data synchronization from a local database to the Microsoft Azure cloud database. 
5.4.3 Recommended System Changeover Strategy
This system is a new initiative for the motor vehicles market, it is not importing any data from any existing database. The recommended system changeover strategy is thereby based on the recommended upgrades on system features. Phased changeover will be recommended once new features have been added to the system since module integration process is broken down into monitored phased. This will ensure that the core features of the system are not affected by an integration of new upgrades to the system.
5.5 Maintenance 
The maintenance strategy is crafted on the basis that the mobile application will require maintenance inorder for it to deliver as expected and adapt to changes and capacity. 
5.5.1 The Decision Support System
The Decision Support System (DSS) connects all the separate entities of the Mota Market system and automate processes. A synchronous relationship of separate system tracing path is created to support each other and to ensure that changes, updates and bugs of a single entity does not affect the entire system.
 

Figure 5.13 Decision Support System


5.5.2 Routine Maintenance
Visual studio will used to conduct corrective maintenance because it has the inbuilt tool to check error, bugs and warnings such as build, debug, code analysis, preview and solution explorer among others.  Adaptive maintenance will also be done using the default integrated development environment (IDE) which is Visual Studio to add user needs to the system. 
5.5.3 Routine Backup
The ASP.Net Core will facilitate scheduled routine synchronization and backup of data from the local SQLite database to the Microsoft Azure cloud using the DSS path. The Xamarin.Essential nugget package will ensure automatic backup whenever a user has a connection after failing to synchronize during the scheduled period.





5.5.4 Objectives versus Real System
Digital Advertising is offered as a premium feature whereby the paid adverts will appear first in the advertisement and explore page of the application as Hot and Featured Adverts. These adverts maybe hot and featured when paid. To achieve this, the administrator will change this in the vehicles table, in the rows Hot and Featured by switching them to true, then the advert will automatically change from free to featured adverts.
Table 5. 1 Vehicles 
 

The vehicles will indicate that they are featured not just in the MyAd page, but every page they appear. If a user is on the Explore page, featured vehicles will be shown, and that trace path is uniform even on a search query. This is shown below:
 
Figure 5.14 Adverts
The system also facilitates communication by ensuring that prospective buyers can easily contact sellers. To achieve this, for every vehicle for sale, the profile of the seller is attached together with contact information such as phone number, physical address and email.
 
Figure 5.15 Buyer to Seller communication

5.6 Recommendations 
Native Cloud Deployment such as Red Hat offers robust security and performance especially as the system attracts big amounts of traffic. The Microsoft Azure cloud deployment is not native hence the database string encapsulates cache to a Linux docker container for reproducible research and data science.
Cloud native machine learning enhances native platform specific Artificial Intelligence (AI) to be used to the mobile applications and Cortana which is Microsoft voice recognition AI. For instance using voice recognition to use the system, Google’s Alexa is the native voice recognition AI for android. Siri is the native speech recognition AI for iOS.  
Extended device coverage can be implemented through Xamarin Forms and C# to watches, tv, desktop pc, mac, embedded IoT devices like google glasses. The power of Xamarin Forms is code reuse, hence 95% of the existing code will work for the extended devices and delivering native applications.  



Transaction processing is recommended once the vehicles market accepts transactions in the local currency. The system should then facilitate transactions by offering cart and checkout features for buyers to purchase motor vehicles of choice. Internet of Things (IoT) can be part of the system to determine the value of the motor vehicles through the use of smart embedded systems. IoT devices will upload data to the system and machine learning will perform asset valuation.
Azure cloud integration is of this system is clustered by Platform as a Service (PaaS). To unilaterally deliver both PaaS, the Decision Support System (DSS) was architecture to facilitate an advanced trace path for a change over strategy of platform specific integration services and embedded nugget packages to efficiently operate on 5G devices. Xamarin Forms nugget manager will update most of these packages however open source could be faster in delivering platform specific integration services which are cross platform. 
5.7 Conclusion
The implementation phase embraced a complete appreciation of developing powerful native cross platform mobile applications using C# and Xamarin Forms. The scope of the research produced a breakthrough solution for the motor vehicles market as well as any industry that may need cross platform mobile applications. This research went a step further by creating a decision support system through the integration of deep learning and business intelligence.



























Reference List
.Net Core Roadmap, Github, June 2020, Web, https://github.com/dotnet/core/blob/master/roadmap.md (last accessed 28 June 2020).
Android Design Guideline, Android, 2020, Web, https://developer.android.com/design/index.html (last accessed 20 June 2020). 

Benjamin Bahrenburg, Appcelerator Titanium Business Application Development Cookbook, 2018. 

comScore Reports January 2019 U.S. Smartphone Subscriber Market Share, comScore, 4 March 2019, Web, https://www.comscore.com/Insights/Rankings/comScore-ReportsJanuary-2019-US-Smartphone-Subscriber-Market-Share (last accessed 26 June 2020)

Creating a Compelling Mobile User Experience, IBM Corporation, IBM Global Business Services, May 2018, Web, https://www935.ibm.com/services/multimedia/Mobile_UX_Whitepaper_ 02May12_VK.pdf (last accessed 20 June 2020). 
Design Universal Windows Platform (UWP) apps, Microsoft, 2020, Web, https://developer.microsoft.com/en-us/windows/apps/design(lastaccessed 20 June 2020).
Esteban Angulo, Xavier Ferre, A Case Study on Cross-Platform Development Frameworks for Mobile Applications and UX, 2014. 

Frequently Asked Questions, Xamarin, 31 March 2019, Web, https://www.xamarin.com/faq#q6 (last accessed 21 June 2020).

Gartner Says Worldwide Sales of Smartphones Grew 7 Percent in the Fourth Quarter of 2019, Gartner, 15 February 2020, Web, http://www.gartner.com/newsroom/id/3609817 (last accessed 26 June 2020)

Introduction to Mobile Development, Xamarin, 2020, Web, https://developer.xamarin.com/guides/crossplatform/getting_started/introduction_to_mobile_development/ #How_Does_Xamarin_Work (last accessed 27 June 2020).

iOS Human Interface Guidelines, iOS, 2020, Web, https://developer.apple.com/ios/human-interfaceguidelines/overview/design-principles/ (last accessed 20 June 2020).

Jay Greene, Microsoft Agrees to Acquire Xamarin, 24 February 2019, Web, https://www.wsj.com/articles/microsoft-agrees-to-acquire-xamarininc-1456340494 (last accessed 27 June 2020).
Mobile and tablet internet usage exceeds desktop for ﬁrst time worldwide, StatCounter, 1 November 2019, Web, http://gs.statcounter.com/press/mobile-and-tablet-internet-usage-exceedsdesktop-for-ﬁrst-time-worldwide (last accessed 26 June 2020).

Mona E. Joorabchi, Ali Mesbah, Philippe Kruchten, Real Challenges in Mobile App Development, 2018. 

Nish Anil, Porting existing .NET apps to Four Mobile Platforms with PCL, 14 January 2014, Web, https://blog.xamarin.com/porting-existingnet-apps-to-four-mobile-platforms-with-pcl/ (last accessed 27 June 2020).

Number of apps available in leading app stores as of March 2020, Statista, Statista GmbH, 2020, Web, https://www.statista.com/statistics/276623/number-of-apps-availablein-leading-app-stores/ (last accessed 20 June 2020). 

Part 1 – Understanding the Xamarin Mobile Platform, Xamarin, 2020, Web, https://developer.xamarin.com/guides/crossplatform/application_fundamentals/building_cross_platform_applications /part_1_-_understanding_the_ xamarin_mobile_platform/ (last accessed 27 June 2020).

Ricardo Alcocer Top 10 tips for building better mobile apps, InfoWorld, 5 May 2019, Web, http://www.infoworld.com/article/2918472/mobiledevelopment/top-10-tips-for-building-better-mobile-apps.html (last accessed 20 June 2020).

Rosario Madaudo, Patrizia Scandurra, Native versus Cross-platform frameworks for mobile application development, 2018. 

Ryan Paul, Xamarin Releases Same-Day Support for iOS 6 Xamarin, 19 September 2018, Web, https://blog.xamarin.com/xamarin-releases-sameday-support-for-ios-6/ (last accessed 21 June 2020). 

Sharing Code Options, Xamarin, 2020, Web, https://developer.xamarin.com/guides/crossplatform/application_fundamentals/code-sharing/ (last accessed 27 June 2020). 

Smartphone Users and Penetration Worldwide, 2014-20200, eMarketer, 06 April 2019, Web, http://www.emarketer.com/Chart/SmartphoneUsers-Penetration-Worldwide-2014-20200-billions-of-mobile-phone-userschange/188679 (last accessed 26 June 2020). 

Tilman Stehle, Porting for Synchronized Cross-Platform Development of Mobile Apps, University of Hamburg, 2020, Web, https://www.inf.unihamburg.de/en/inst/ab/swk/research/current-research-projects/crossplatform.html/ (last accessed 27 June 2020).
Tilmann Stehle, Matthias Riebisch, Establishing Common Architectures for Porting Mobile Applications to new Platforms, 2019. 

Volkan Tunali, Senol Z. Erdogan, Comparison of Popular Cross-Platform Mobile Application Development Tools, 2019.

Wafaa S. El-Kassas, Bassem A. Abdullah, Ahmed H. Yousef, Ayman M. Wahba, Taxonomy of Cross-Platform Mobile Applications Development Approaches, Ain Shams Engineering Journal p. 166, 2019.

Xamarin,Wikipedia,Web, https://en.wikipedia.org/wiki/Xamarin(lastaccessed 27 June 2020). 

Xamarin.Forms, Xamarin, 2020, Web, https://www.xamarin.com/forms (last accessed 26 June 2020).

