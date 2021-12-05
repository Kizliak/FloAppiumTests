Feature: TrackMyCycle
	As a user
	I want to be able to track my cycle

Background: 
	Given Welcome menu is open

@mytag
Scenario: Check if it is possible to run the app in the Track my cycle mode from the Welcome menu
	When I tap on Track my cycle button
	Then the result should be 120