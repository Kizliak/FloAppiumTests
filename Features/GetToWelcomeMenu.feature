Feature: GetToWelcomeMenu
	As a user
	I would like to agree with rules and info tracking
	In order to get on welcome menu page

Scenario: Accept all rules and decline info tracking
	When I tap on 'Accept All' link
	When I tap on 'Next' button
	When I decline tracking my activity
	Then I get I see main menu with title 'Welcome to Flo! How can we help you?'