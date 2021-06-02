Feature: lambdaTest_bdd
	 Select first two items in the ToDoApp
    Enter a new item in the ToDoApp
    Add the new item to the list

@Test
Scenario:Add items to the ToDoApp
	Given that I am on the LambdaTest Sample app <profile> and <environment>
   #Given that I am on the LambdaTest Sample app single and chrome
    Then select the first item
    Then select the second item
    Then find the text box to enter the new value
    Then click the Submit button
    And  verify whether the item is added to the list
   Then close the browser instance


Examples:
        | profile   | environment |
        | single    | chrome      |
        | parallel  | chrome      |
        | parallel  | firefox     |
        | parallel  | safari      |
        | parallel  | ie          |


@Test2

Scenario:Add  Three items to the ToDoApp
	Given that I am on the LambdaTest Sample app
    Then select the first item
    Then select the second item
    Then select the Third item
    Then find the text box to enter the new value
    Then click the Submit button
    And  verify whether the item is added to the list
    Then close the browser instance

  
 @Test3
 Scenario:To do Google Search
Given  Launch Google Chrome
When Navigate to Google Search
Then Search for LamdaTest
And Click on the first test result

 @Test4
 Scenario:To do Firefox Search
Given Launch Firefox server
When Navigate to Firefox Search
Then Search for LamdaTest
And Click on the first test result