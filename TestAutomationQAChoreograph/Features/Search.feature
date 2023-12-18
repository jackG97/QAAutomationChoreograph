Feature: Search

The Search feature where users can search for clothing items on the website

@tag1
Scenario: User can search for clothes using the search function
	Given I am signed in as a user on the home page
	When I enter 'Jackets' in the search bar at the top of the page
	And I press the enter key
	Then I should be taken to page which displays the results of the search
	And I can select the item I want
