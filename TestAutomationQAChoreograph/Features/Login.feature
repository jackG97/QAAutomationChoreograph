Feature: Login

Login Functionality

@tag1
Scenario: User can login into Magento
	Given I am on the Home page
	When I select the Sign In button at the top of the screen
	And I enter in my email address and password
	And I select Sign In button at the bottm of the screen
	Then I see my account page


Scenario: User cannot create an account when they already have one
	Given I am on the Home page
	When I select the Create an Account button at the top of the screen
	And I enter my sign information and personal information
	And I select Create an Account button at the bottm of the screen
	Then I see an error message stating I already have an account
	