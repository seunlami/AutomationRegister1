Feature: Registration
	Completing a registration form

@mytag
Scenario: Registration
	Given I navigate to website
	And I click on register
	And I enter first name
	And I enter last name
	And I enter address
	And I enter email address
	And I enter phone number
	And I select my gender
	And I select my hobbies
	#And I select my language
	#And I select skills
	#And I select country
	#And I select date of birth
	And I enter password
	And I confirm password
	When I click on Submit button
	#Then I shouuld have completed the registration form