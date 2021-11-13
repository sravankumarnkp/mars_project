Feature: Profile
	As a Seller
	I want to add my profile details
	So that
	The people seeking for some skills, profile data, description and Availability can look into my Profile page. 
#profile name
@Profilename
Scenario Outline: Test 01 Edit Profile with First Name and Last Name
	Given I Logged into Profile Page sucessfully
	And I clicked on edit button
	When I entered '<Firstname>' and '<Lastname>', And click on save button
	Then the result sholud be saved.
	Examples: 
	| Firstname | Lastname |
	| Joshi     | Kan      |

@Profilename
Scenario: Test 02 Edit Profile with out First Name and Last Name
	Given I Logged into Profile Page sucessfully
	And I clicked on edit button
	When I entered empty Firstname and Lastname, And click on save button
	Then  a popup should be shown with this message (First Name, Last Name are reqired)
	
@Profilename
Scenario: Test 03 Edit Profile with out First Name and with  Last Name
	Given I Logged into Profile Page sucessfully
	And I clicked on edit button
	When I entered  with out Firstname and kumar as Lastname   , And click on save button
	Then  a popup should be shown with this message (First Name, Last Name are reqired)
	
	#end Profilename
@Profilename
Scenario: Test 04 Edit Profile with First Name and with out Last Name
	Given I Logged into Profile Page sucessfully
	And I clicked on edit button
	When I entered  with out Firstname and kumar as Lastname   , And click on save button
	Then  a popup should be shown with this message (First Name, Last Name are reqired)


    
    #	profiledetails Availability
    @Profiledetails
    Scenario: Test 05 Add Profile Availability successfully
        Given I logged into Trade Skills portal successfully
        And I click on Availability pen icon
        When I select value from the dorpdown 
        Then Availability should be saved successfully
        
    #	profiledetails Hours
    @Profiledetails
	Scenario: Test 06 Profile Hours successfully
        Given I logged into Trade Skills portal successfully
        And I click on Hours pen icon
        When I select value from the dorpdown 
        Then Hours should be saved successfully
        
    	#profiledetails Earn Target
    @Profiledetails
    Scenario:Test 07 Profile Earn Target successfully
        Given I logged into Trade Skills portal successfully
        And I click on Earn Target pen icon
        When I select value from the dorpdown 
        Then Earn Target should be saved successfully

		#profile descrption 
		@profiledescription @Onboarding
		Scenario Outline: Test 08 Change description with some description on my profile successfully
		Given I logged into Trade Skills portal successfully
		And I click on Description edit pen icon
		When I edit the '<description>' And click on save button
		Then '<description>'  should be saved sucessfully on profile page

		Examples: 
		| description                                                                                                         |
		| my name is sravan, i have some skills and i want to share my skils. please find my availabilties on profile page |
		| 1                                                                                                                    |
		
		#profile descrption  
		@profiledescription @Onboarding
		Scenario Outline: Test 09 change  description with not accepted data on my profile
		Given I logged into Trade Skills portal successfully
		And I click on Description edit pen icon
		When I edit the '<description>' And click on save button
		Then '<description>' should not be saved saved or  Pop up message displayed stat with letter or digit
		Examples: 
		| description |
		| @           |

		#profile Languages 
		@profileLanguages @Onboarding
Scenario Outline: Test 10 Add a languages succcessfully
	Given I logged into Trade Skills portal successfully
	When i click on languages tab, and click on addnew button and chooselanguage as '<lname>' 
	And i choose level as '<level>' and clickon add button
	Then Pop up message displayed as '<lname>'  has been added to your languages
	Examples: 
	| lname   | level |
	| hindi   | Basic |
	| english | Basic |
	#profileLanguages same languages

@profileLanguages @Onboarding
Scenario Outline: Test 11 Add a Duplicate data languages 
	Given I logged into Trade Skills portal successfully
	When i click on languages tab, and click on addnew button and chooselanguage as '<lname>' 
	And i choose level as '<level>' and clickon add button
	Then Pop up message displayed as Duplicated data
	Examples: 
	| lname | level  |
	| hindi | Fluent |
	#profileLanguages with out languages level
@profileLanguages 
Scenario Outline: Test 12 Add a  languages  with out level should pop up Error message 
	Given I logged into Trade Skills portal successfully
	When i click on anguages tab, and click on addnew button and chooselanguage as '<lname>' 
	And i dont choose level and clickon add button
	Then Pop up message displayed as please enter languages level
	Examples: 
	| lname |
	| hindi |
	#profileLanguages edit  languages 
	@profileLanguages @Onboarding
Scenario Outline: Test 13 Edit a languages should pop up sucessfully 
	Given I logged into Trade Skills portal successfully
	When i click on languages tab, and click on  edit button   add choose language as '<lang>' 
	And i choose '<level>' and clickon update button
	Then Pop up message displayed english   has been updated  to your languages
	Examples: 
	| lang    | level          |
	| english | Conversational |	
	#profileLanguages edit  languages
	@profileLanguages 
Scenario: Test 14 Edit a languages with same languages should pop up Error message 
	Given I logged into Trade Skills portal successfully
	When i click on languages tab, and click on  edit button   add choose language as english 
	And i choose level and clickon update button
	Then Pop up message displayed as Duplicated data
	#profileLanguages delete
@certification @Onboarding
Scenario: Test 28 delete languages details
	Given I logged into Trade Skills portal successfully
	When Seller click on languages tab
	And Seller delete his languages with '<lang>'
	Then Pop up massage displayed as languages entry successfully removed
	Examples: 
	| lang    |
	| english |

		#profile skill edit
		@profileskill
Scenario: Test 15 Add a skill succcessfully
	Given I logged into Trade Skills portal successfully
	When i click on skill tab, and click on add new button and skill as html 
	And i choose level as expert and clickon add button
	Then Pop up massage displayed as html  has been added to your skill
	
#profile skill 
		@profileskill 
Scenario Outline: Test 16 Add a skill with same skill should pop up Error message 
	Given I logged into Trade Skills portal successfully
	When i click on skill tab, and click on addnew button and choose skill as '<skill>' 
	And i choose '<level>'  and clickon add button
	Then Pop up message displayed as Duplicated data
	Examples: 
	| skill   | level    |
	| testing | beginner |
	#profileskill with out skill level
@profileskill
Scenario Outline: Test 17 Add a  skill  with out level should pop up Error message 
	Given I logged into Trade Skills portal successfully
	When i click on addnew button and choose skill as '<skill>'
	And i dont choose level and clickon add button
	Then Pop up message displayed as please enter skill level
	Examples: 
	| skill |
	| testing |
	#profile skill edit  skill 
	@profileskill
Scenario Outline: Test 18 Edit a skill should pop up sucessfully 
	Given I logged into Trade Skills portal successfully
	When i click on edit button   add choose skill as '<skill>'
	And i choose '<level>'   and clickon update button
	Then Pop up message displayed html   has been added to your skill
	Examples: 
	| skill | level   |
	| html  | beginner |
	#profile edit  skill 
	@profileskill
Scenario Outline: Test 19 Edit a skill with same skill and level should pop up Error message 
	Given I logged into Trade Skills portal successfully
	When i click on edit button   add choose skill as '<skill>'
	And i choose '<level>' and clickon update button
	Then Pop up message displayed as Duplicated data
	Examples: 
	| skill | level   |
	| html  | beginner |
	#profileeducation add  skill 
@Education 
Scenario: Test 20 Add education with all valid data
	Given I logged into Trade Skills portal successfully
	When Seller click on education tab 
	And Seller add his education university as jntu
	And Seller select country as india and title as btech
	And Seller add degree as Information Technology
	And Seller select education year as 2009
	Then Pop up massage displayed as Education has been added

@Education 
Scenario: Test 21 Edit education data
 Given I logged into Trade Skills portal successfully
	When I click on education tab
	And i click on  edit button and choose  education university as hyder
	Then Pop up massage displayed as Education as been updated

@Education 
Scenario: Test 22 Edit education data same data 
 Given I logged into Trade Skills portal successfully
	When I click on education tab
	And i click on  edit button and choose  education university as hyder
	Then Pop up massage displayed as information already exist

@Education 
Scenario: Test 23 delete education details
	Given I logged into Trade Skills portal successfully
	When Seller click on education tab
	And Seller delete his education raw with university as NIBM
	Then Pop up massage displayed as Education entry successfully removed

#certification add

@certification
Scenario: Test 24 Add certification with all valid data
	Given I logged into Trade Skills portal successfully
	When Seller click on certification tab and Seller add his certificate name  as istqb
	And Seller select certificate from testing
	And Seller select certificate year as 2009
	Then Pop up massage displayed as certificate has been added

#certification edit
@certification 
Scenario: Test 25 Edit certification data
 Given I logged into Trade Skills portal successfully
	When I click on certification tab
	And i click on  edit button and choose  certification from  software
	Then Pop up massage displayed as certification as been updated
	#certification edit
@certification 
Scenario: Test 26 Edit certification data same data 
 Given I logged into Trade Skills portal successfully
	When I click on certification tab
	And i click on  edit button and choose  certification from  software
	Then Pop up massage displayed as already exsits
	#certification delete
@certification 
Scenario: Test 27 delete certification details
	Given I logged into Trade Skills portal successfully
	When Seller click on certification tab
	And Seller delete his certification with istqb
	Then Pop up massage displayed as Education entry successfully removed

