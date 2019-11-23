set -e
#set -x

echo "Pushing changes to master..."

git checkout master
echo "Checkout master done"

git merge work
echo "Merge work done"

git push
echo "Push master done"
