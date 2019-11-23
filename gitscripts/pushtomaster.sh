set -e
#set -x

echo "Pushing changes to master..."

git merge master
echo "Merge master done"

git checkout master
echo "Checkout master done"

git merge work
echo "Merge work done"
