# UnitTesting-Moq-Examples #
<a target="_blank" href="LICENSE"><img src="https://img.shields.io/badge/licence-MIT-brightgreen.svg" alt="license : MIT"></a>
<a target="_blank" href="https://github.com/moq/moq4"><img src="https://img.shields.io/badge/framwork-Moq-blue.svg" alt="license : MIT"></a>
<a target="_blank" href="https://www.nuget.org/packages/Moq"><img src="https://img.shields.io/badge/nuget-Moq-yellowgreen.svg" alt="license : MIT"></a>


## Why Unit Testing? ##
Unit Testing is improving software quality by identifying and resolving defects before they are leaked into production. The main unit testing platforms are MS Test, NUnit or xUnit. Unit testing can be performed on this platforms using different framework. MOQ is one of the unit testing framework which can be used in this platform for unit testing.

Read more on <a target="_blank" href="https://www.cmarix.com/importance-of-unit-testing-in-software-development/">Importance Of Unit Testing In Software Development</a>

## Install Moq ##
You can install “Moq” in your project with MS Test using “NuGet Package Manager” UI or console.

    Install-Package Moq

## How to Use Moq ##

To use the Moq, it's very easy. Mainly it has 3 steps basic process.
	
1. Creating the object of user class.
	
    	// Create a mock object of a User class which implements IUser
        var mock = new Moq.Mock<IUser>();

2. Setup the methods of user class as per your need.

		// Configure dummy method so that it return true when it gets any string as parameters to the method.
		mock.Setup(User => User.IsAdmin).Returns(true);

3. Verify that the particular method of the interface was invoked.
 
	    // Verify that the User's MakePayment methods gets called exactly once when IsAdmin property value is true
	    mock.Verify(x => x.MakePayment());


## Let us know! ##
We’d be really happy if you sent us links to your projects where you use our component. Just send an email to [biz@cmarix.com](mailto:biz@cmarix.com "biz@cmarix.com") and do let us know if you have any questions or suggestion regarding unit testing in c#.

P.S. We’re going to publish more awesomeness examples on third party libaries, coding standards, plugins etc, in all the technology. Stay tuned!

## License ##

	MIT License
	
	Copyright © 2019 CMARIX TechnoLabs
	
	Permission is hereby granted, free of charge, to any person obtaining a copy
	of this software and associated documentation files (the "Software"), to deal
	in the Software without restriction, including without limitation the rights
	to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
	copies of the Software, and to permit persons to whom the Software is
	furnished to do so, subject to the following conditions:
	
	The above copyright notice and this permission notice shall be included in all
	copies or substantial portions of the Software.
	
	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
	LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
	OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
	SOFTWARE.
