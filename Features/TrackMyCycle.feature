Feature: TrackMyCycle
	As a user
	I want to be able to track my cycle

Background:
	Given Welcome menu is open

Scenario: Check if it is possible to run the app in the Track my cycle mode from the Welcome menu
	When I tap on Track my cycle button
	When I tap on I don't remember checkbox
	When I tap on don't remember Next button
	When I swipe from Select to one position up
	When I tap on year born Next button
	When I tap on 'My cycle is regular' answer button
	When I tap on 'No, nothing bothers me' answer button
	When I tap on Next answer button
	When I tap on 'No' answer button
	When I tap on 'No, I sleep well' answer button
	When I tap on Next answer button
	When I tap on 'Nothing, I'm totally fine' answer button
	When I tap on Next answer button
	When I tap on 'Nothing, I'm totally satisfied' answer button
	When I tap on Next answer button
	When I tap on 'None' answer button
	When I tap on Next answer button
	When I tap on 'None, I have perfect skin' answer button
	When I tap on Next answer button
	When I tap on No button on Do you take supplements
	When I tap on Welcome mode page Next button
	When I tap on Welcome mode page Next button
	When I tap on Welcome mode page Next button
	When I tap on Choose your plan X button