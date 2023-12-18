Feature: MailingList

Users using the mailing list feature

@tag1
Scenario: User can subscribe to the mailing list
	Given I am logged in with an account
	When I select 'Subscribe to our mailing list' option
	And Im directed to the subscribe form
	And I submit my details via the form page 
	Then I should be subscribed the mailing list
