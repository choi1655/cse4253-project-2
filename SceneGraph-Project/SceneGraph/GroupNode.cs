using System;
using System.Collections.Generic;
using Choi.SceneGraph;

namespace Choi.SceneGraphCore
{
    public class GroupNode: IGroupNode
    {
        public string Name
        {
            get;
            private set;
        }

        public GroupNode()
        {
        }

        public void Accept(IVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void AddChild(ISceneNode child)
        {
            throw new NotImplementedException();
        }

        #region Member variables
        // List to keep track of the cihldren for the group
        private IList<ISceneNode> children = new List<ISceneNode>(8);

        #endregion
    }
}
