


class Node:
    def __init__(self):
        self.children = []
        self.val = None


def foo(node,a,b):

    if not node:
        return 0,0,0

    a_found,b_found= node.val==a,node.val == b
    local_val = node.val if (a_found or b_found) else 0

    for child in node.children:
        temp = foo(child,a,b)
        if temp[0] and temp[1]:
            return 1,1,temp[2]

        if temp[0]:
            a_found = 1
            local_val+=temp[2]

        if temp[1]:
            b_found = 1
            local_val+=temp[2]

    return a_found,b_found,local_val

