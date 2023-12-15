Feature: NewClothing

A short summary of the feature

@tag1
Scenario: User can view whats new in the shop
	Given I am logged into my account
	When I Select the Whats New option on my main menu
	And Im redirected to the Whats New Page
	And I Scroll down towards the bottom of the page
	Then I see New clothing available
