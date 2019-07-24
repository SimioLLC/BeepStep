using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using SimioAPI;
using SimioAPI.Extensions;

namespace BeepStep
{
    class Beep1StepDefinition : IStepDefinition
    {
        #region IStepDefinition Members

        /// <summary>
        /// Property returning the full name for this type of step. The name should contain no spaces. 
        /// </summary>
        public string Name
        {
            get { return "Beep1"; }
        }

        /// <summary>
        /// Property returning a short description of what the step does.  
        /// </summary>
        public string Description
        {
            get { return "Beep flavor 1"; }
        }

        /// <summary>
        /// Property returning an icon to display for the step in the UI. 
        /// </summary>
        public System.Drawing.Image Icon
        {
            get { return null; }
        }

        /// <summary>
        /// Property returning a unique static GUID for the step.  
        /// </summary>
        public Guid UniqueID
        {
            get { return MY_ID; }
        }
        static readonly Guid MY_ID = new Guid("{97F38958-BB0F-42E9-A6D5-C2D587520385}");

        /// <summary>
        /// Property returning the number of exits out of the step. Can return either 1 or 2. 
        /// </summary>
        public int NumberOfExits
        {
            get { return 1; }
        }

        /// <summary>
        /// Method called that defines the property schema for the step.
        /// </summary>
        public void DefineSchema(IPropertyDefinitions schema)
        {
        }

        /// <summary>
        /// Method called to create a new instance of this step type to place in a process. 
        /// Returns an instance of the class implementing the IStep interface.
        /// </summary>
        public IStep CreateStep(IPropertyReaders properties)
        {
            return new Beep1Step(properties);
        }

        #endregion
    }

    class Beep1Step : IStep
    {
        IPropertyReaders _properties;
        public Beep1Step(IPropertyReaders properties)
        {
            _properties = properties;
        }

        #region IStep Members

        /// <summary>
        /// Method called when a process token executes the step.
        /// </summary>
        public ExitType Execute(IStepExecutionContext context)
        {
            SystemSounds.Asterisk.Play();
            context.ExecutionInformation.TraceInformation("Beep2");
            return ExitType.FirstExit;
        }

        #endregion
    }
}
