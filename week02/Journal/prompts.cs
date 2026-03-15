using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts;
    public string GetPrompt()
    { //List of prompts.
        _prompts = new List<string>();
        _prompts.Add("What is the most vivid color you have seen today?");
        _prompts.Add("What is your favorite scent?");
        _prompts.Add("What is one of you pet peeves?");
        _prompts.Add("Who is one person you know you can talk to if you're having a bad day?");
        _prompts.Add("If you could be a vaction, what king of vaction would you be and why?");

        //Random prompt picker.
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}


